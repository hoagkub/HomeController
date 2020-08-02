namespace HomeController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnViewSensor = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSet = new System.Windows.Forms.Button();
            this.btnInsta = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnFb = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.introductionFrame1 = new HomeController.IntroductionFrame();
            this.sensorFrame1 = new HomeController.SensorFrame();
            this.homeFrame1 = new HomeController.HomeFrame();
            this.connectionFrame1 = new HomeController.ConnectionFrame();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnViewSensor);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnConnection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 508);
            this.panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(3, 462);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(38, 43);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 38);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 43);
            this.SidePanel.TabIndex = 3;
            // 
            // btnViewSensor
            // 
            this.btnViewSensor.FlatAppearance.BorderSize = 0;
            this.btnViewSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSensor.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSensor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewSensor.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSensor.Image")));
            this.btnViewSensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSensor.Location = new System.Drawing.Point(12, 136);
            this.btnViewSensor.Name = "btnViewSensor";
            this.btnViewSensor.Size = new System.Drawing.Size(153, 43);
            this.btnViewSensor.TabIndex = 5;
            this.btnViewSensor.Text = "View Sensor";
            this.btnViewSensor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSensor.UseVisualStyleBackColor = true;
            this.btnViewSensor.Click += new System.EventHandler(this.btnViewSensor_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 87);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(153, 43);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "    Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnection.Location = new System.Drawing.Point(12, 38);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(153, 43);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connection";
            this.btnConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 10);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_App);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_App);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_App);
            // 
            // btnSet
            // 
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSet.Image = ((System.Drawing.Image)(resources.GetObject("btnSet.Image")));
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSet.Location = new System.Drawing.Point(719, 16);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(40, 43);
            this.btnSet.TabIndex = 10;
            this.btnSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnInsta
            // 
            this.btnInsta.FlatAppearance.BorderSize = 0;
            this.btnInsta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsta.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsta.Image = ((System.Drawing.Image)(resources.GetObject("btnInsta.Image")));
            this.btnInsta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsta.Location = new System.Drawing.Point(577, 16);
            this.btnInsta.Name = "btnInsta";
            this.btnInsta.Size = new System.Drawing.Size(40, 43);
            this.btnInsta.TabIndex = 9;
            this.btnInsta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsta.UseVisualStyleBackColor = true;
            // 
            // btnShutDown
            // 
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutDown.Location = new System.Drawing.Point(811, 16);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(40, 43);
            this.btnShutDown.TabIndex = 8;
            this.btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnNotification.Image")));
            this.btnNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotification.Location = new System.Drawing.Point(765, 16);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(40, 43);
            this.btnNotification.TabIndex = 7;
            this.btnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotification.UseVisualStyleBackColor = true;
            // 
            // btnFb
            // 
            this.btnFb.FlatAppearance.BorderSize = 0;
            this.btnFb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFb.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFb.Image = ((System.Drawing.Image)(resources.GetObject("btnFb.Image")));
            this.btnFb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFb.Location = new System.Drawing.Point(623, 16);
            this.btnFb.Name = "btnFb";
            this.btnFb.Size = new System.Drawing.Size(40, 43);
            this.btnFb.TabIndex = 6;
            this.btnFb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFb.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(171, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 80);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "mang lại sự tiện lợi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giải pháp công nghệ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Easy Controller";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // introductionFrame1
            // 
            this.introductionFrame1.BackColor = System.Drawing.SystemColors.Control;
            this.introductionFrame1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("introductionFrame1.BackgroundImage")));
            this.introductionFrame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.introductionFrame1.Location = new System.Drawing.Point(165, 96);
            this.introductionFrame1.Name = "introductionFrame1";
            this.introductionFrame1.Size = new System.Drawing.Size(698, 409);
            this.introductionFrame1.TabIndex = 14;
            // 
            // sensorFrame1
            // 
            this.sensorFrame1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sensorFrame1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sensorFrame1.BackgroundImage")));
            this.sensorFrame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sensorFrame1.Location = new System.Drawing.Point(165, 96);
            this.sensorFrame1.Name = "sensorFrame1";
            this.sensorFrame1.Size = new System.Drawing.Size(698, 409);
            this.sensorFrame1.TabIndex = 13;
            // 
            // homeFrame1
            // 
            this.homeFrame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(214)))), ((int)(((byte)(189)))));
            this.homeFrame1.Location = new System.Drawing.Point(165, 96);
            this.homeFrame1.Name = "homeFrame1";
            this.homeFrame1.Size = new System.Drawing.Size(698, 409);
            this.homeFrame1.TabIndex = 12;
            // 
            // connectionFrame1
            // 
            this.connectionFrame1.BackColor = System.Drawing.SystemColors.Control;
            this.connectionFrame1.Location = new System.Drawing.Point(165, 96);
            this.connectionFrame1.Name = "connectionFrame1";
            this.connectionFrame1.Size = new System.Drawing.Size(698, 409);
            this.connectionFrame1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(863, 508);
            this.Controls.Add(this.introductionFrame1);
            this.Controls.Add(this.sensorFrame1);
            this.Controls.Add(this.homeFrame1);
            this.Controls.Add(this.connectionFrame1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnInsta);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.btnFb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Controller";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnViewSensor;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnFb;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnInsta;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ConnectionFrame connectionFrame1;
        private HomeFrame homeFrame1;
        private SensorFrame sensorFrame1;
        private IntroductionFrame introductionFrame1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

