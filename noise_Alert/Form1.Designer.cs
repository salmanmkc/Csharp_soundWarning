namespace noise_Alert
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.audioLevelText = new System.Windows.Forms.Label();
            this.audioLevel = new System.Windows.Forms.ProgressBar();
            this.selectDevice = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Audio Device";
            // 
            // audioLevelText
            // 
            this.audioLevelText.AutoSize = true;
            this.audioLevelText.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioLevelText.Location = new System.Drawing.Point(294, 50);
            this.audioLevelText.Name = "audioLevelText";
            this.audioLevelText.Size = new System.Drawing.Size(19, 19);
            this.audioLevelText.TabIndex = 1;
            this.audioLevelText.Text = "0";
            // 
            // audioLevel
            // 
            this.audioLevel.Location = new System.Drawing.Point(172, 46);
            this.audioLevel.Name = "audioLevel";
            this.audioLevel.Size = new System.Drawing.Size(100, 23);
            this.audioLevel.TabIndex = 2;
            // 
            // selectDevice
            // 
            this.selectDevice.FormattingEnabled = true;
            this.selectDevice.Location = new System.Drawing.Point(30, 46);
            this.selectDevice.Name = "selectDevice";
            this.selectDevice.Size = new System.Drawing.Size(121, 21);
            this.selectDevice.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 117);
            this.Controls.Add(this.selectDevice);
            this.Controls.Add(this.audioLevel);
            this.Controls.Add(this.audioLevelText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noise Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label audioLevelText;
        private System.Windows.Forms.ProgressBar audioLevel;
        private System.Windows.Forms.ComboBox selectDevice;
        private System.Windows.Forms.Timer timer1;
    }
}

