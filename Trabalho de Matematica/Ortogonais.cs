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
    public partial class Ortogonais : Form
    {
        public Ortogonais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1 = 0, r2 = 0, r3 = 0, r4 = 0;
            int x1 = Convert.ToInt32(txtX.Text);
            int y1 = Convert.ToInt32(txtY.Text);
            int z1 = Convert.ToInt32(txtZ.Text);


            int x2 = Convert.ToInt32(txtX.Text);
            int y2 = Convert.ToInt32(txtY.Text);
            int z2 = Convert.ToInt32(txtZ.Text);




            r1 = x1 * x2;
            r2 = y1 * y2;
            r3 = z1 * z2;
            r4 = r1 + r2 + r3;
            txtX.Text = r1.ToString();
            txtY.Text = r2.ToString();
            txtZ.Text = r3.ToString();
            txtR.Text = r4.ToString();
            lblR.Text = "( " + x1.ToString() + " * " + x2.ToString() + " ) + ( " + y1.ToString() + " * " + y2.ToString() + " ) + (" + z1.ToString() + " * " + z2.ToString() + " ) = " + r1.ToString() + " + " + r2.ToString() + " + " + r3.ToString() + " = " + r4.ToString();
            if (r4 == 0)
            {
                lblRR.Text = "O vetor é Ortogonal";
            }
            else
            {
                lblRR.Text = "O vetor não é Ortogonal";
            }




        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(txtX.Text);
            int x2 = Convert.ToInt32(txtR.Text);
            int ortogonais = x1 * x2;
            lblR.Text = ortogonais.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
            txtR.Text = "";
            lblR.Text = "";
            lblRR.Text = "";
        }
    }
}
