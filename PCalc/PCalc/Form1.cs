using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; //globais
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button5_Click(object sender, EventArgs e)
        {
            txtBx1.Text = "";
            txtBx2.Text = "";
            txtBx3.Text = "";
            /* OU
            txtBx1.Text = String.Empty;
            txtBx2.Text = String.Empty;
            txtBx3.Text = String.Empty; */

            /* OU
            txtBx1.Clear();
            txtBx2.Clear();
            txtBx3.Clear(); */
        }


        private void Button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            //txtBx3 = txtBx1.Text + txtBx2.Text;
            if ((double.TryParse(txtBx1.Text, out numero1)) && 
                (double.TryParse(txtBx2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtBx3.Text = resultado.ToString();

                //btnLimpar_click(sender, e); // AQUI
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }

        private void BtnSubtração_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtBx1.Text, out numero1)) && 
                (double.TryParse(txtBx2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtBx3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }

        private void BtnMultiplição_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtBx1.Text, out numero1)) && 
                (double.TryParse(txtBx2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtBx3.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }

        private void BtnDivisão_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtBx1.Text, out numero1)) && 
                (double.TryParse(txtBx2.Text, out numero2)))
            {
                if (numero1 != 0 && numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    txtBx3.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("divisão por 0!");
                }
            }
            else
            {
                MessageBox.Show("Números inválidos!");
            }
        }

        private void TxtBx1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBx1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido!");
                //txtBx1.Focus();
            }
        }
        private void TxtBx2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBx2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido!");
                //txtBx2.Focus();
            }
        }
    }
}
