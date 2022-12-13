using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIndows_Forms_Array
{
    public partial class Form1 : Form
    {
        // Datentyp[] Bezeichnung = new Datentyp[Größe]
        int[] zahlen = new int[10];
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_eingabe_Click(object sender, EventArgs e)
        {
            zahlen[counter] = Convert.ToInt32(txt_Eingabe.Text);
            txt_Ausgabe.Text = counter.ToString() + " / " + zahlen[counter].ToString();
            counter++;
        }

        private void btn_ausgabe_Click(object sender, EventArgs e)
        {
            int rechnung = 0;
            txt_Ausgabe.Text = "";
            for (int i = 0; i < zahlen.Length; i++)
            {
                txt_Ausgabe.Text += i.ToString() + " / " + zahlen[i].ToString() + Environment.NewLine;
            }

            for (int i = 0; i < zahlen.Length; i++)
            {
                if (i == zahlen.Length - 1)
                {
                    txt_Ausgabe.Text += zahlen[i].ToString() + " = ";
                }
                else
                {
                    txt_Ausgabe.Text += zahlen[i].ToString() + " + ";
                }
                rechnung += zahlen[i];
            }

            txt_Ausgabe.Text += Environment.NewLine + rechnung.ToString();
        }
    }
}
