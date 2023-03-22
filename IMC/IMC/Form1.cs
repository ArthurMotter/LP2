using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        double Peso = 0, Altura = 0, Imc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtBxPeso.Text, out Peso)) &&
                (double.TryParse(txtBxAltura.Text, out Altura)))
            {
                Imc = Peso / Math.Pow(Altura, 2);
                txtBxIMC.Text = Imc.ToString();
                if (Imc < 18.5)
                {
                    txtBxClassific.Text = ("classificação: Magreza");
                    txtBxObesidade.Text = ("obesidade: 0");
                }
                if (Imc >= 18.5 && Imc < 24.9)
                {
                    txtBxClassific.Text = ("classificação: Normal");
                    txtBxObesidade.Text = ("obesidade: 0");
                }
                if (Imc >= 25 && Imc < 29.9)
                {
                    txtBxClassific.Text = ("classificação: Sobrepeso");
                    txtBxObesidade.Text = ("obesidade: 1");
                }
                if (Imc >= 30 && Imc < 39.9)
                {
                    txtBxClassific.Text = ("classificação: Obesidade");
                    txtBxObesidade.Text = ("obesidade: 2");
                }
                if (Imc >= 40)
                {
                    txtBxClassific.Text = ("classificação: Obesidade Mórbida");
                    txtBxObesidade.Text = ("obesidade: 3");
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBxPeso.Text = string.Empty;
            txtBxAltura.Text = string.Empty;
            txtBxIMC.Text = string.Empty;
            txtBxClassific.Text = string.Empty;
            txtBxObesidade.Text = string.Empty;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBxPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBxPeso.Text, out Peso))
            {
                MessageBox.Show("Valor inválido!");
            }
        }

        private void txtBxAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBxAltura.Text, out Altura))
            {
                MessageBox.Show("Valor inválido!");
            }
        }
    }
}
