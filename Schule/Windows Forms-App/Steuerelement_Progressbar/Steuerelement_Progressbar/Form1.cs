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
        double txt = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void pgb_display_Click(object sender, EventArgs e)
        {
            // Display the ProgressBar control.
            pgb_display.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            pgb_display.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            pgb_display.Maximum = Convert.ToInt32(txt);
            // Set the initial value of the ProgressBar.
            pgb_display.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            pgb_display.Step = 1;

            // Loop through all files to copy.
            for (double x = 1; x <= txt; x += 0.01)
            {
                // Perform the increment on the ProgressBar.
                Task.Delay(2000).Wait();
                pgb_display.PerformStep();
            }
        }
    }
}
