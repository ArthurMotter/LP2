using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placos
{
    public partial class frmExercicio4 : Form
    {
        string nome, cargo, matricula;
        int producao;
        double salario, gratificacao;

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double A = 0;
            int B, C, D;
            double salBruto;
            if ((double.TryParse(textBox5.Text, out salario)) &&
                int.TryParse(textBox4.Text, out producao) && 
                double.TryParse(textBox6.Text, out gratificacao))
                
            {
                if(producao >= 150)
                {
                    D = 1; C = 1; B = 1;
                }
                else if (producao >= 120)
                {
                    D = 0; C = 1; B = 1;
                }
                else if (producao >= 100)
                {
                    D = 0; C = 0; B = 1;
                }
                else
                {
                    D = 0;  C = 0; B = 0;
                }

                if (salario < 7000)
                {
                    A = salario;
                }
                else if (salario >= 7000 && D != 0 && gratificacao != 0)
                {
                    A = salario;
                }
                else
                {
                    salario = 7000;
                }
                salBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

                MessageBox.Show("nome: " + nome + "\ncargo: " + cargo + "\nmatrícula: " + 
                    matricula + "\nprodução: " + producao + "\n salário bruto: " + salBruto
                    + "\ngratificação: " + gratificacao);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)
                || char.IsControl(e.KeyChar))
            {
                nome = textBox1.Text;
            }
            else
            {
                MessageBox.Show("valor inválido!");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)
                || char.IsControl(e.KeyChar))
            {
                cargo = textBox2.Text;
            }
            else
            {
                MessageBox.Show("valor inválido!");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            matricula = textBox3.Text;
        }
    }
}
