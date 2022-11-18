using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGB_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            pgb_01.Minimum = 0;
            pgb_01.Maximum = 100;
            pgb_01.Step = 1;
            //pgb_01.Style = ProgressBarStyle.Marquee;
            pgb_01.Value = 20;

            InitializeComponent();
        }

        private void pgb_01_Click(object sender, EventArgs e)
        {
        }

        private void btn_stepper_Click(object sender, EventArgs e)
        {
            pgb_01.Value++;
        }
    }
}
