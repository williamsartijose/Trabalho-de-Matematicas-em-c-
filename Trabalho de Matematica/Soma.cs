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
    public partial class Soma : Form
    {
        public Soma()
        {
            InitializeComponent();
        }

        private void Soma_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
       

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
          
            int x1 = Convert.ToInt32(txtX.Text);
            int x2 = Convert.ToInt32(txtX.Text);
            int y1 = Convert.ToInt32(txtY.Text);

            int y2 = Convert.ToInt32(txtY.Text);

            int z1 = Convert.ToInt32(txtZ.Text);
            int z2 = Convert.ToInt32(txtZ.Text);


            lblRS.Text = "( " + x1.ToString() + " + " + x2.ToString() + " ) + ( " + y1.ToString() + " + " + y2.ToString() + " ) + ( " + z1.ToString() + " + " + z2.ToString() + " )= " + ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";

            lblRS.Text = "";
               

        }
    }
}
