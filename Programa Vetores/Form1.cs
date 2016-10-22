using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Vetores
{
   public partial class Form1 : Form
    {

        #region Variaveis
        int x1, x2, y1, y2, z1, z2;
        Bitmap background = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + @"\bg.bmp");
        #endregion
        #region Métodos
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        ///Método Que Realiza Soma de Inteiros
        /// </summary>
        private void CalculaSoma()

        {   x1 = Int32.Parse(valorx1.Text);
            y1 = Int32.Parse(valory1.Text);
            z1 = Int32.Parse(valorz1.Text);
            x2 = Int32.Parse(valorx2.Text);
            y2 = Int32.Parse(valory2.Text);
            z2 = Int32.Parse(valorz2.Text);

            int x = x1 + x2;
            int y = y1 + y2;
            int z = z1 + z2;
            resposta.Text = "A Soma dos Vetores é: (" + x + " ," + y + ", " + z + ")";
        }
        public override Image BackgroundImage
        {
            get
            {
                return background;
            }
            set
            {
                if (value != null)
                {
                    //Cria um novo bitmap com os valores recebidos
                    background = new Bitmap(value.Width, value.Height);

                    //Cria um grafico a partir da imagem
                    Graphics gra = Graphics.FromImage(background);

                    //modifica a interpolacao dos graficos para alto
                    gra.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

                    //desenha a imagem sobre o grafico que sera usada no OnPaint do background
                    gra.DrawImage(value, new Rectangle(0, 0, background.Width, background.Height));
                }
                else
                    background = null;
            }
        }
        #endregion


        #region Action Performed

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculaSoma();

        } 

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(valorx1.Text);
            int y1 = Int32.Parse(valory1.Text);
            int z1 = Int32.Parse(valorz1.Text);
            int x2 = Int32.Parse(valorx2.Text);
            int y2 = Int32.Parse(valory2.Text);
            int z2 = Int32.Parse(valorz2.Text);
            int x = x1 - x2;
            int y = y1 - y2;
            int z = z1 - z2;
            resposta.Text = "A Subtração dos Vetores é: (" + x + ", " + y + ", " + z + ")";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(valorx1.Text);
            int y1 = Int32.Parse(valory1.Text);
            int z1 = Int32.Parse(valorz1.Text);
            int x2 = Int32.Parse(valorx2.Text);
            int y2 = Int32.Parse(valory2.Text);
            int z2 = Int32.Parse(valorz2.Text);
            int invalido = 0;
            if (x1==0 && y1==0 && z1 == 0)
            {
                resposta.Text = "Informe os Valores no Vetor U !!!";
                invalido = 1;
            }
            if (invalido != 1)
            {
                resposta.Text = "O Módulo do Vetor é: " + Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valorx1.Text = "0";
            valorx2.Text = "0";
            valory1.Text = "0";
            valory2.Text = "0";
            valorz1.Text = "0";
            valorz2.Text = "0";
            resposta.Text = "RESPOSTA";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(valorx1.Text);
            int y1 = Int32.Parse(valory1.Text);
            int z1 = Int32.Parse(valorz1.Text);
            int x2 = Int32.Parse(valorx2.Text);
            int y2 = Int32.Parse(valory2.Text);
            int z2 = Int32.Parse(valorz2.Text);
            double rad = (((x1 * x2) + (y1 * y2) + (z1 * z2)) / ((Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2))) * Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2) + Math.Pow(z2, 2))));
            double resp = Math.Acos(rad);
            resp = (resp * 180) / Math.PI;
            resposta.Text = "O Ângulo entre os Vetores U e V é igual a: " + resp; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(valorx1.Text);
            int y1 = Int32.Parse(valory1.Text);
            int z1 = Int32.Parse(valorz1.Text);
            int x2 = Int32.Parse(valorx2.Text);
            int y2 = Int32.Parse(valory2.Text);
            int z2 = Int32.Parse(valorz2.Text);
            int comp = ((x1 * x1) + (y1 * y2) + (z1 * z2));
            if (comp == 0)
            {
                resposta.Text = "Os Vetores são Ortogonais";
            }
            if (comp != 0)
            {
                resposta.Text = "Os Vetores não são Ortogonais";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(valorx1.Text);
            int y1 = Int32.Parse(valory1.Text);
            int z1 = Int32.Parse(valorz1.Text);
            int x2 = Int32.Parse(valorx2.Text);
            int y2 = Int32.Parse(valory2.Text);
            int z2 = Int32.Parse(valorz2.Text);
            int invalido = 0;
            double resp = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2));
            if(x1==0 && y1==0 && z1==0)
            {
                resposta.Text = "Informe os Valores no Vetor U!!!";
                invalido = 1;
                
            }
            if (resp == 1)
            {
                resposta.Text = "O Vetor é Unitário";
            }
            if (resp != 1 && invalido!=1)
            {
                resposta.Text = "O Vetor não é Unitário";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(valorx1.Text);
            int y1 = Int32.Parse(valory1.Text);
            int z1 = Int32.Parse(valorz1.Text);
            int x2 = Int32.Parse(valorx2.Text);
            int y2 = Int32.Parse(valory2.Text);
            int z2 = Int32.Parse(valorz2.Text);
            resposta.Text = "O Produto Escalar é Igual a: " + ((x1 * x2) + (y1 * y2) + (z1 * z2));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(valorx1.Text);
            int y1 = Int32.Parse(valory1.Text);
            int z1 = Int32.Parse(valorz1.Text);
            int x2 = Int32.Parse(valorx2.Text);
            int y2 = Int32.Parse(valory2.Text);
            int z2 = Int32.Parse(valorz2.Text);
            int i = ((y1 * z2) - (y2 * z1));
            int j = ((z1 * x2) - (z2 * x1));
            int k = ((x1 * y2) - (x2 * y1));
            resposta.Text = "O Produto Vetorial é igual a: " + i + "i   " + j + "j   " + k + "k";
        }

#endregion
    }
}
