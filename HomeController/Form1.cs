using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HomeController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnConnection.Height;
            SidePanel.Top = btnConnection.Top;
            connectionFrame1.BringToFront();
        }
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        // Thao tác di chuyển vị trí ứng dụng
        int mouseX = 0; int mouseY = 0; bool mouseDown;
        private void MouseDown_App(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            
        }
        
        private void MouseMove_App(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 210;
                mouseY = MousePosition.Y - 35;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void MouseUp_App(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        /// </summary>
        

        private void btnConnection_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btnConnection.Height;
            SidePanel.Top = btnConnection.Top;
            connectionFrame1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeFrame1.BringToFront();
        }

        private void btnViewSensor_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Height = btnViewSensor.Height;
            SidePanel.Top = btnViewSensor.Top;
            sensorFrame1.progressbarCircleTemp.Value = connectionFrame1.dataIn;
            sensorFrame1.tvTempValue.Text = sensorFrame1.progressbarCircleTemp.Value.ToString() + " C";
            sensorFrame1.BringToFront();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SidePanel.Show();
            SidePanel.Hide();
            introductionFrame1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sensorFrame1.progressbarCircleTemp.Value = connectionFrame1.dataIn;
            sensorFrame1.tvTempValue.Text = sensorFrame1.progressbarCircleTemp.Value.ToString() + " C";
        }
    }
}
