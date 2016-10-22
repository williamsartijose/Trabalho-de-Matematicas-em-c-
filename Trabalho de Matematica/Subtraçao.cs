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
    public partial class Subtraçao : Form
    {
        public Subtraçao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(txtX.Text);
            int x2 = Convert.ToInt32(txtXX.Text);
        
          int Subtraçao = x1 - x2 ;


            lblRes.Text = Subtraçao.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y1 = Convert.ToInt32(txtY.Text);
            int y2 = Convert.ToInt32(txtYY.Text);
            
            int Subtraçao = y1  -  y2;
            
            
            lblRe.Text = Subtraçao.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z1 = Convert.ToInt32(txtZ.Text);
            int z2 = Convert.ToInt32(txtZZ.Text);

            int Subtraçao = z1 - z2;


            lblR.Text = Subtraçao.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
