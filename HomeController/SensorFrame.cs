using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeController
{
    public partial class SensorFrame : UserControl
    {
        public SensorFrame()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressbarCircleTemp.Value != 100)
            {
                progressbarCircleTemp.Value++;
                tvTempValue.Text = progressbarCircleTemp.Value.ToString() + "C";
            }
            else
            {
                progressbarCircleTemp.Value=0;
            }
        }

    }
}
