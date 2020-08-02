using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToggleSlider;

namespace HomeController
{
    public partial class HomeFrame : UserControl
    {
        public HomeFrame()
        {
            InitializeComponent();
        }

        private void toggleSwitchDeviceOne_CheckChanged(object sender, EventArgs e)
        {
            if (toggleSwitchDeviceOne.Checked)
            {
                ptFan.Image = Properties.Resources.fan;
            }
            else
            {
                ptFan.Image = Properties.Resources.fanoff;
            }
        }

        private void toggleSwitchDeviceTwo_CheckChanged(object sender, EventArgs e)
        {
            if (toggleSwitchDeviceTwo.Checked)
            {
                ptLamp.Image = Properties.Resources.lampbulbon;
            }
            else
            {
                ptLamp.Image = Properties.Resources.lampbulboff;
            }
        }


        


       
    }
}
