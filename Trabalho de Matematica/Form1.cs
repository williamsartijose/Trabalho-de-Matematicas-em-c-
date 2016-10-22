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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subtraçãoDeVetoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void somaDeVetoresToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soma som = new Soma();
            som.Show();




        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void subtraçãoDeVetoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Subtraçao sub = new Subtraçao();
            sub.Show();
        }

        private void moduloToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Modulo mod = new Modulo();
            mod.Show();
        }

        private void ortogonaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ortogonais or = new Ortogonais();
            or.Show();
        }

        private void anguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Angulo ang = new Angulo();
            ang.Show();
        }
    }
}
