namespace HomeController
{
    partial class ConnectionFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionFrame));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStopbit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDatabit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenPort = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tvStateConnect = new System.Windows.Forms.Label();
            this.progressConnection = new System.Windows.Forms.ProgressBar();
            this.tvSendBox = new System.Windows.Forms.TextBox();
            this.tvReceiveBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearDataReceived = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClosePort = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSendData = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbStopbit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDatabit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbComPort);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(84, 131);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 21);
            this.cbParity.TabIndex = 8;
            this.cbParity.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "STOP BITS";
            // 
            // cbStopbit
            // 
            this.cbStopbit.FormattingEnabled = true;
            this.cbStopbit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopbit.Location = new System.Drawing.Point(84, 104);
            this.cbStopbit.Name = "cbStopbit";
            this.cbStopbit.Size = new System.Drawing.Size(121, 21);
            this.cbStopbit.TabIndex = 6;
            this.cbStopbit.Text = "One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATA BITS";
            // 
            // cbDatabit
            // 
            this.cbDatabit.FormattingEnabled = true;
            this.cbDatabit.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDatabit.Location = new System.Drawing.Point(84, 77);
            this.cbDatabit.Name = "cbDatabit";
            this.cbDatabit.Size = new System.Drawing.Size(121, 21);
            this.cbDatabit.TabIndex = 4;
            this.cbDatabit.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cbBaud.Location = new System.Drawing.Point(84, 50);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 21);
            this.cbBaud.TabIndex = 2;
            this.cbBaud.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(84, 23);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 21);
            this.cbComPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Controls.Add(this.btnClosePort);
            this.groupBox2.Controls.Add(this.btnOpenPort);
            this.groupBox2.Controls.Add(this.tvStateConnect);
            this.groupBox2.Controls.Add(this.progressConnection);
            this.groupBox2.Location = new System.Drawing.Point(16, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.CheckedState.Parent = this.btnOpenPort;
            this.btnOpenPort.CustomImages.Parent = this.btnOpenPort;
            this.btnOpenPort.FillColor = System.Drawing.Color.Silver;
            this.btnOpenPort.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenPort.ForeColor = System.Drawing.Color.White;
            this.btnOpenPort.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnOpenPort.HoverState.Parent = this.btnOpenPort;
            this.btnOpenPort.Location = new System.Drawing.Point(15, 18);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.ShadowDecoration.Parent = this.btnOpenPort;
            this.btnOpenPort.Size = new System.Drawing.Size(66, 23);
            this.btnOpenPort.TabIndex = 8;
            this.btnOpenPort.Text = "OPEN";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click_1);
            // 
            // tvStateConnect
            // 
            this.tvStateConnect.AutoSize = true;
            this.tvStateConnect.Font = new System.Drawing.Font("Myriad Hebrew", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvStateConnect.Location = new System.Drawing.Point(42, 44);
            this.tvStateConnect.Name = "tvStateConnect";
            this.tvStateConnect.Size = new System.Drawing.Size(77, 15);
            this.tvStateConnect.TabIndex = 4;
            this.tvStateConnect.Text = "Disconnected";
            // 
            // progressConnection
            // 
            this.progressConnection.Location = new System.Drawing.Point(6, 67);
            this.progressConnection.Name = "progressConnection";
            this.progressConnection.Size = new System.Drawing.Size(151, 13);
            this.progressConnection.TabIndex = 2;
            // 
            // tvSendBox
            // 
            this.tvSendBox.Location = new System.Drawing.Point(0, 16);
            this.tvSendBox.Multiline = true;
            this.tvSendBox.Name = "tvSendBox";
            this.tvSendBox.Size = new System.Drawing.Size(223, 99);
            this.tvSendBox.TabIndex = 3;
            // 
            // tvReceiveBox
            // 
            this.tvReceiveBox.Location = new System.Drawing.Point(0, 16);
            this.tvReceiveBox.Multiline = true;
            this.tvReceiveBox.Name = "tvReceiveBox";
            this.tvReceiveBox.ReadOnly = true;
            this.tvReceiveBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tvReceiveBox.Size = new System.Drawing.Size(387, 99);
            this.tvReceiveBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tvSendBox);
            this.groupBox3.Location = new System.Drawing.Point(16, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Box";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearDataReceived);
            this.groupBox4.Controls.Add(this.tvReceiveBox);
            this.groupBox4.Location = new System.Drawing.Point(245, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 125);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive Box";
            // 
            // btnClearDataReceived
            // 
            this.btnClearDataReceived.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearDataReceived.Location = new System.Drawing.Point(393, 16);
            this.btnClearDataReceived.Name = "btnClearDataReceived";
            this.btnClearDataReceived.Size = new System.Drawing.Size(40, 99);
            this.btnClearDataReceived.TabIndex = 5;
            this.btnClearDataReceived.Text = "Clear all";
            this.btnClearDataReceived.UseVisualStyleBackColor = false;
            this.btnClearDataReceived.Click += new System.EventHandler(this.btnClearDataReceived_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ReceiveData);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnClosePort
            // 
            this.btnClosePort.CheckedState.Parent = this.btnClosePort;
            this.btnClosePort.CustomImages.Parent = this.btnClosePort;
            this.btnClosePort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClosePort.FillColor2 = System.Drawing.Color.SlateGray;
            this.btnClosePort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClosePort.ForeColor = System.Drawing.Color.White;
            this.btnClosePort.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnClosePort.HoverState.Parent = this.btnClosePort;
            this.btnClosePort.Location = new System.Drawing.Point(91, 18);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.ShadowDecoration.Parent = this.btnClosePort;
            this.btnClosePort.Size = new System.Drawing.Size(66, 23);
            this.btnClosePort.TabIndex = 9;
            this.btnClosePort.Text = "CLOSE";
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click_1);
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.Color.Transparent;
            this.btnSendData.CheckedState.Parent = this.btnSendData;
            this.btnSendData.CustomImages.Parent = this.btnSendData;
            this.btnSendData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSendData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSendData.ForeColor = System.Drawing.Color.White;
            this.btnSendData.HoverState.Parent = this.btnSendData;
            this.btnSendData.Location = new System.Drawing.Point(163, 27);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSendData.ShadowDecoration.Parent = this.btnSendData;
            this.btnSendData.Size = new System.Drawing.Size(50, 50);
            this.btnSendData.TabIndex = 8;
            this.btnSendData.Text = "SEND";
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click_1);
            // 
            // ConnectionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConnectionFrame";
            this.Size = new System.Drawing.Size(698, 409);
            this.Load += new System.EventHandler(this.ConnectionFrame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStopbit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDatabit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressConnection;
        private System.Windows.Forms.TextBox tvSendBox;
        private System.Windows.Forms.TextBox tvReceiveBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label tvStateConnect;
        private System.Windows.Forms.Button btnClearDataReceived;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnOpenPort;
        private Guna.UI2.WinForms.Guna2GradientButton btnClosePort;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnSendData;

    }
}
