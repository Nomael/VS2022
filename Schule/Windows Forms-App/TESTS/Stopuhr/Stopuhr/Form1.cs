using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopuhr
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            label1.Text = "0";
            button1.Text = "Starten";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
                button1.Text = "Starten";
            }
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button1.Text = "Stopen";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = Convert.ToString(counter);
        }
    }
}
