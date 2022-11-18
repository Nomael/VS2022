using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knopf_Bewegung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nud_NummericX.Maximum = 100;
            nud_NummericX.Minimum = -100;
            nud_NummericY.Maximum = 100;
            nud_NummericY.Minimum = -100;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            btn_button.Left += 1;
            btn_button.Top += 1;
        }

        private void btn_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
