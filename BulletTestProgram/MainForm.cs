using System.Windows.Forms;

namespace BulletTestProgram
{
    public partial class MainForm : Form
    {
        // Constants
        private const float bulletMass = 0.0034f; // Mass of bullet in kg (3.4 grams)
        private const float airResistance = 0.2f; // Air resistance coefficient
        private const float gravity = 9.8f; // Gravity acceleration in m/s²

        // Simulation parameters
        private float time = 0; // Time variable
        private float deltaTime = 0.05f; // Time increment per tick

        // Start position of the bullet
        private int startX = 291; // Bullet start X-coordinate
        private int startY = 218; // Bullet start Y-coordinate

        // Initial speed components
        private float initialVelocityX;
        private float initialVelocityY;

        public MainForm()
        {
            InitializeComponent();

            // Set initial values for angle and velocity controls
            numericUpDownAngle.Value = 10; // Start with a lower angle for a flatter trajectory
            numericUpDownVelocity.Value = 880; // Initial speed in m/s (can be adjusted)

            // Set initial position of bullet
            pictureBoxBullet.Location = new Point(startX, startY);

            // Set up the timer event handler
            timerBullet.Interval = 50; // Timer interval
            timerBullet.Tick += Timer_Tick;
        }

        private void UpdateVelocityComponents()
        {
            // Convert angle to radians
            float angle = (float)numericUpDownAngle.Value;
            float angleRad = angle * (float)Math.PI / 180;

            // Calculate initial velocity components based on the angle and velocity
            float initialVelocity = (float)numericUpDownVelocity.Value;
            initialVelocityX = initialVelocity * (float)Math.Cos(angleRad); // Horizontal component
            initialVelocityY = initialVelocity * (float)Math.Sin(angleRad); // Vertical component

            // Reset time
            time = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            UpdateVelocityComponents(); // Recalculate velocity components with updated values
            timerBullet.Start(); // Start the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Calculate new position using initial velocities
            float x = initialVelocityX * time; // Horizontal position
            float y = initialVelocityY * time - 0.5f * gravity * time * time; // Vertical position

            // Update bullet position relative to the start position
            pictureBoxBullet.Left = startX + (int)x; // Move horizontally from the start point
            pictureBoxBullet.Top = startY - (int)y; // Move vertically (downwards is +y, so we subtract)

            // Check for collision with the target
            if (pictureBoxBullet.Bounds.IntersectsWith(pictureBoxTarget.Bounds))
            {
                timerBullet.Stop();
                MessageBox.Show("The bullet hit the target!");
            }

            // Stop the simulation if the bullet goes out of bounds
            if (pictureBoxBullet.Top > this.ClientSize.Height || pictureBoxBullet.Left > this.ClientSize.Width)
            {
                timerBullet.Stop();
                MessageBox.Show("The bullet missed the target.");
            }

            // Increase the time step
            time += deltaTime;
        }

    }
}
