using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Matematica
{
    public partial class Angulo : Form
    {
        public Angulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1 = 0, r2 = 0, r3 = 0, r4 = 0;
            int x1 = Convert.ToInt32(txtA.Text);
            int y1 = Convert.ToInt32(txtAA.Text);
            int z1 = Convert.ToInt32(txtAAA.Text);


            int x2 = Convert.ToInt32(txtA.Text);
            int y2 = Convert.ToInt32(txtAA.Text);
            int z2 = Convert.ToInt32(txtAAA.Text);

            r1 = ((x1 * x2) + (y1 * y2) + (z1 * z2));
            r2 = Math.Sqrt((Math.Pow(x1, 2)) + (Math.Pow(y1, 2)) + Math.Pow(z1, 2));
            r3 = Math.Sqrt((Math.Pow(x2, 2)) + (Math.Pow(y2, 2)) + (Math.Pow(z2, 2)));
            r4 = r1 / r2 * r3;
            txtA.Text = r1.ToString();
            txtAA.Text = r2.ToString();
            txtAAA.Text = r3.ToString();
            txtR.Text = r4.ToString();
            lblR.Text = "(" + x1.ToString() + " * " + x2.ToString() + ") + (" + y1.ToString() + " * " + y2.ToString() + ") + (" + z1.ToString() + " * " + z2.ToString() + ") = " + r1.ToString() + " / ";
            lblRR.Text = r2.ToString() + " * " + r3.ToString() + " = " + r4.ToString();






        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtA.Text = "";
            txtAA.Text = "";
            txtAAA.Text = "";
            txtR.Text = "";
            lblR.Text = "";
            lblRR.Text = "";
        }
    }
}
