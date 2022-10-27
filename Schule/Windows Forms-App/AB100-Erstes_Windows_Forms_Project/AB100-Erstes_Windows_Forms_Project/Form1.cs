using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB100_Erstes_Windows_Forms_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLESEN_Click(object sender, EventArgs e)
        {
            lblAusgabe.Text = txtEingabe.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
