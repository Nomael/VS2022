using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steuerelement_Progressbar
{
    public partial class Form1 : Form
    {
        int pgb_max = 2000000;
        int pgb_min = 0;
        int pgb_step = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_stprog_Click(object sender, EventArgs e)
        {
            pgb_display.Visible = true;

            label1.Text = "Continuous:";

            pgb_display.Maximum = pgb_max;

            pgb_display.Minimum = pgb_min;
            
            pgb_display.Step = pgb_step;
            
            pgb_display.Style = ProgressBarStyle.Continuous;


            for (int i = pgb_min; i < pgb_max; i++)
            {
                pgb_display.Value = i;
            }

            MessageBox.Show("ffffff");
        }

        private void btn_stprog2_Click(object sender, EventArgs e)
        {
            pgb_display2.Visible = true;

            label2.Text = "Marquee:";

            pgb_display2.Maximum = pgb_max;

            pgb_display2.Minimum = pgb_min;

            pgb_display2.Step = pgb_step;

            pgb_display2.Style = ProgressBarStyle.Marquee;

            pgb_display2.Value = 100;
        }

        private void btn_stprog3_Click(object sender, EventArgs e)
        {
            pgb_display3.Visible = true;

            label3.Text = "Blocks:";

            pgb_display3.Maximum = pgb_max;

            pgb_display3.Minimum = pgb_min;

            pgb_display3.Step = pgb_step;

            pgb_display3.Style = ProgressBarStyle.Blocks;

            for (int i = pgb_min; i < pgb_max; i++)
            {
                pgb_display3.Value = i;

                //Task.Delay(1000).Wait();
                //pgb_display.PerformStep();
                //pgb_display3.PerformStep();
            }
        }
    }
}
