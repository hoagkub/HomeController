using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HomeController
{
    public partial class ConnectionFrame : UserControl
    {
        string dataOut;
        string dataIn;
        public ConnectionFrame()
        {
            InitializeComponent();
            btnOpenPort.Enabled = true;
            btnClosePort.Enabled = false;
        }

        private void ConnectionFrame_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
        }

        private void btnOpenPort_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaud.Text);
                serialPort1.DataBits = Convert.ToInt32(cbDatabit.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopbit.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);

                serialPort1.Open();
                progressConnection.Value = 100;
                tvStateConnect.Text = "Connected";
                tvStateConnect.ForeColor = System.Drawing.Color.Green;
                btnOpenPort.Enabled = false;
                btnClosePort.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClosePort_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressConnection.Value = 0;
                tvStateConnect.Text = "Disonnected";
                tvStateConnect.ForeColor = System.Drawing.Color.Red;
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
            }
        }
        private void btnSendData_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = tvSendBox.Text.ToString().Trim();
                serialPort1.WriteLine(dataOut);
            }
        }
        /// <summary>
        /// Xoa man hinh nhan data
        private void btnClearDataReceived_Click(object sender, EventArgs e)
        {
            tvReceiveBox.Clear();
        }
        /// </summary>

        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            //dataIn = serialPort1.ReadExisting();
            //string line = serialPort1.ReadExisting();
            int da =serialPort1.ReadChar();
            string line = da.ToString();
            //this.Invoke(new EventHandler(ShowData));
            this.BeginInvoke(new ShowDataEvent(ShowData), line);
        }
        private delegate void ShowDataEvent(string line);
        private void ShowData(string line)
        {
            tvReceiveBox.Text = "Nhiệt độ: "+ line +" degrees";
            //tvReceiveBox.AppendText(dataIn);
               //auto scroll
            tvReceiveBox.SelectionStart = tvReceiveBox.TextLength;
            tvReceiveBox.ScrollToCaret();
        }

        

        

        

      
    }
}
