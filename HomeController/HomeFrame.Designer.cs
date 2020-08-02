namespace HomeController
{
    partial class HomeFrame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrame));
            this.label1 = new System.Windows.Forms.Label();
            this.toggleSwitchDeviceOne = new ToggleSlider.ToggleSliderComponent();
            this.toggleSwitchDeviceTwo = new ToggleSlider.ToggleSliderComponent();
            this.ptLamp = new System.Windows.Forms.PictureBox();
            this.ptFan = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptLamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptFan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fan";
            // 
            // toggleSwitchDeviceOne
            // 
            this.toggleSwitchDeviceOne.AutoSize = true;
            this.toggleSwitchDeviceOne.Checked = false;
            this.toggleSwitchDeviceOne.Location = new System.Drawing.Point(279, 131);
            this.toggleSwitchDeviceOne.Name = "toggleSwitchDeviceOne";
            this.toggleSwitchDeviceOne.Size = new System.Drawing.Size(109, 28);
            this.toggleSwitchDeviceOne.TabIndex = 1;
            this.toggleSwitchDeviceOne.ToggleBarText = "Device One";
            this.toggleSwitchDeviceOne.ToggleCircleColor = System.Drawing.Color.Fuchsia;
            this.toggleSwitchDeviceOne.ToggleColorBar = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toggleSwitchDeviceOne.CheckChanged += new System.EventHandler(this.toggleSwitchDeviceOne_CheckChanged);
            // 
            // toggleSwitchDeviceTwo
            // 
            this.toggleSwitchDeviceTwo.AutoSize = true;
            this.toggleSwitchDeviceTwo.Checked = false;
            this.toggleSwitchDeviceTwo.Location = new System.Drawing.Point(279, 283);
            this.toggleSwitchDeviceTwo.Name = "toggleSwitchDeviceTwo";
            this.toggleSwitchDeviceTwo.Size = new System.Drawing.Size(109, 28);
            this.toggleSwitchDeviceTwo.TabIndex = 2;
            this.toggleSwitchDeviceTwo.ToggleBarText = "Device Two";
            this.toggleSwitchDeviceTwo.ToggleCircleColor = System.Drawing.Color.Fuchsia;
            this.toggleSwitchDeviceTwo.ToggleColorBar = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toggleSwitchDeviceTwo.CheckChanged += new System.EventHandler(this.toggleSwitchDeviceTwo_CheckChanged);
            // 
            // ptLamp
            // 
            this.ptLamp.Image = ((System.Drawing.Image)(resources.GetObject("ptLamp.Image")));
            this.ptLamp.Location = new System.Drawing.Point(48, 185);
            this.ptLamp.Name = "ptLamp";
            this.ptLamp.Size = new System.Drawing.Size(176, 126);
            this.ptLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptLamp.TabIndex = 6;
            this.ptLamp.TabStop = false;
            // 
            // ptFan
            // 
            this.ptFan.Image = global::HomeController.Properties.Resources.fanoff;
            this.ptFan.Location = new System.Drawing.Point(48, 33);
            this.ptFan.Name = "ptFan";
            this.ptFan.Size = new System.Drawing.Size(176, 126);
            this.ptFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptFan.TabIndex = 5;
            this.ptFan.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bulb";
            // 
            // HomeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(189)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptLamp);
            this.Controls.Add(this.ptFan);
            this.Controls.Add(this.toggleSwitchDeviceTwo);
            this.Controls.Add(this.toggleSwitchDeviceOne);
            this.Controls.Add(this.label1);
            this.Name = "HomeFrame";
            this.Size = new System.Drawing.Size(698, 409);
            ((System.ComponentModel.ISupportInitialize)(this.ptLamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptFan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ToggleSlider.ToggleSliderComponent toggleSwitchDeviceOne;
        private ToggleSlider.ToggleSliderComponent toggleSwitchDeviceTwo;
        private System.Windows.Forms.PictureBox ptFan;
        private System.Windows.Forms.PictureBox ptLamp;
        private System.Windows.Forms.Label label2;
    }
}
