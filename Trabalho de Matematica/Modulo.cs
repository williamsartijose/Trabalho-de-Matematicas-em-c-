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
    public partial class Modulo : Form
    {
        public Modulo()

        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            double r1 = 0, r2 = 0, r3 = 0, r4 = 0 , aux = 0;
            int x1 = Convert.ToInt32(txtM.Text);
            int y1 = Convert.ToInt32(txtMM.Text);
            int z1 = Convert.ToInt32(txtMMM.Text);


            int x2 = Convert.ToInt32(txtM.Text);
            int y2 = Convert.ToInt32(txtMM.Text);
            int z2 = Convert.ToInt32(txtMMM.Text);
            
            
            r1 = Math.Pow(x1, 2);
            r2 = Math.Pow(y1, 2);
            r3 = Math.Pow(z1, 2);
            aux = r1 + r2 + r3;
            r4 = Math.Sqrt(aux);
            txtM.Text = r1.ToString();
            txtMM.Text = r2.ToString();
            txtMMM.Text = r3.ToString();
           txtR.Text = r4.ToString();

           label6.Text = "v( " + x1.ToString() + "² " + y1.ToString() + "² " + z1.ToString() + "² ) = v( " + r1.ToString() + " + " + r2.ToString() + " + " + r3.ToString() + " ) = " + "v" + aux.ToString() + " = " + r4.ToString();



        }

        private void Modulo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtM.Text = "";

            txtMM.Text = "";
            txtMMM.Text = "";
            txtR.Text = "";
            label6.Text = "";
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        
        
            
        }
    }

