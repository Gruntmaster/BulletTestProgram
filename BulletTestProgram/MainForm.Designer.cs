namespace BulletTestProgram
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBoxTarget = new PictureBox();
            timerBullet = new System.Windows.Forms.Timer(components);
            pictureBoxBullet = new PictureBox();
            numericUpDownAngle = new NumericUpDown();
            numericUpDownVelocity = new NumericUpDown();
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVelocity).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTarget
            // 
            pictureBoxTarget.Image = (Image)resources.GetObject("pictureBoxTarget.Image");
            pictureBoxTarget.Location = new Point(875, 160);
            pictureBoxTarget.Name = "pictureBoxTarget";
            pictureBoxTarget.Size = new Size(77, 127);
            pictureBoxTarget.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTarget.TabIndex = 1;
            pictureBoxTarget.TabStop = false;
            // 
            // timerBullet
            // 
            timerBullet.Interval = 10;
            timerBullet.Tick += Timer_Tick;
            // 
            // pictureBoxBullet
            // 
            pictureBoxBullet.Image = (Image)resources.GetObject("pictureBoxBullet.Image");
            pictureBoxBullet.Location = new Point(291, 218);
            pictureBoxBullet.Name = "pictureBoxBullet";
            pictureBoxBullet.Size = new Size(42, 18);
            pictureBoxBullet.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBullet.TabIndex = 2;
            pictureBoxBullet.TabStop = false;
            // 
            // numericUpDownAngle
            // 
            numericUpDownAngle.Location = new Point(66, 406);
            numericUpDownAngle.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDownAngle.Name = "numericUpDownAngle";
            numericUpDownAngle.Size = new Size(120, 23);
            numericUpDownAngle.TabIndex = 3;
            // 
            // numericUpDownVelocity
            // 
            numericUpDownVelocity.Location = new Point(67, 455);
            numericUpDownVelocity.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericUpDownVelocity.Name = "numericUpDownVelocity";
            numericUpDownVelocity.Size = new Size(120, 23);
            numericUpDownVelocity.TabIndex = 4;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(242, 436);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 588);
            Controls.Add(buttonStart);
            Controls.Add(numericUpDownVelocity);
            Controls.Add(numericUpDownAngle);
            Controls.Add(pictureBoxBullet);
            Controls.Add(pictureBoxTarget);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarget).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAngle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVelocity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bullet;
        private PictureBox pictureBoxTarget;
        private System.Windows.Forms.Timer timerBullet;
        private PictureBox pictureBoxBullet;
        private NumericUpDown numericUpDownAngle;
        private NumericUpDown numericUpDownVelocity;
        private Button buttonStart;
    }
}
