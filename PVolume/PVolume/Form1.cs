using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PVolume
{
    public partial class Form1 : Form
    {
        double Raio, Altura, Volume;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out Raio)) //ler raio do cilindro
            {
                MessageBox.Show("Raio inválido!");
                //Focus();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out Altura)) //ler altura do cilindro
            {
                MessageBox.Show("Altura inválida!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!double.TryParse(textBox1.Text, out Raio))
                && (!double.TryParse(textBox2.Text, out Altura)))
            {
                MessageBox.Show("valores inválidos!");
            }
            else
            {
                if ((double.TryParse(textBox1.Text, out Raio))
                && (double.TryParse(textBox2.Text, out Altura)))
                {
                    Volume = 3.14 * (Raio * Raio) * Altura;  //calcular
                    textBox3.Text = Volume.ToString();
                }
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); //fechar janela
        }
    }
}
