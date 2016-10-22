using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFernandoBrito
{
    public partial class Matriz1 : Form
    {
        public Matriz1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //matrizes posicao 2
            float[,] Matriz2 = new float[3, 2];
            float[] Vetoraux2b = new float[5];
            float[] Vetoraux2a = new float[3];
            float a=0;
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox2.Text);
            int y1 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);
            int z1 = Convert.ToInt32(textBox5.Text);
            int z2 = Convert.ToInt32(textBox6.Text);
            Matriz2[0, 0] = x1;
            Matriz2[0, 1] = x2;
            Matriz2[1, 0] = y1;
            Matriz2[1, 1] = y2;
            Matriz2[2, 0] = z1;
            Matriz2[2, 1] = z2;
            a = -(y1);
            Vetoraux2b[0] = x2 * (-(y1));
            Vetoraux2b[1] = x2 * z1;
            Vetoraux2b[2] = Vetoraux2b[0] + y2;
            Vetoraux2b[3] = z2 - (Vetoraux2b[1]);
            Vetoraux2b[4] = Vetoraux2b[3] / (-(Vetoraux2b[2]));
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label15.Text = x2.ToString() +". ("+a.ToString()+"b + "+z1.ToString()+ " ) "+y2.ToString()+"b = "+z2.ToString();
            label12.Text = Vetoraux2b[0].ToString()+"b + "+ Vetoraux2b[1].ToString()+" + ("+y2.ToString()+"b) = "+z2.ToString();
            label13.Text = Vetoraux2b[2].ToString() + "b = " + Vetoraux2b[3].ToString();
            label14.Text = "b = "+Vetoraux2b[4].ToString();
            //calcular o valor de A
            Vetoraux2a[0] = (y1 * Vetoraux2b[4]) + z1;
            label16.Text = "a = "+a.ToString()+" . "+ Vetoraux2b[4].ToString()+" + "+z1.ToString();
            label17.Text = "a = "+Vetoraux2a[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            label1.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        }
    }
}
