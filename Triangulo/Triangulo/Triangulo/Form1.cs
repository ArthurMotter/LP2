using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        double valA = 0, valB = 0, valC = 0;
        string resultado;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void TxtbxA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtbxA.Text, out valA))
            {
                MessageBox.Show("Valor inválido!");
                //txtBx.Focus();
            }
        }

        private void TxtbxB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtbxB.Text, out valB))
            {
                MessageBox.Show("Valor inválido!");
            }
        }

        private void TxtbxC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtbxC.Text, out valC))
            {
                MessageBox.Show("Valor inválido!");
            }
        }

        private void CalcTriangulo_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtbxA.Text, out valA)) &&
                (double.TryParse(txtbxB.Text, out valB)) && 
                (double.TryParse(txtbxC.Text, out valC)))
            {
                bool existe = false;
                // calculo de existência de um triângulo

                double absolutoBC = Math.Abs(valB - valC);
                double absolutoAC = Math.Abs(valA - valC);
                double absolutoAB = Math.Abs(valA - valB);

                if (absolutoBC < valA && valA < valB + valC) //| b - c |< a < b + c
                {
                    existe = true;
                }
                if (absolutoAC < valB && valB < valA + valC) //| a - c |< b < a + c
                {
                    existe = true;
                }
                if (absolutoAB < valC && valC < valA + valB) //| a - b |< c < a + b
                {
                    existe = true;
                }

                if (existe == false) // triângulo teoricamente impossivel
                {
                    txtbxTipo.Text = "não existe/inválido";
                }
                else // triângulo possível de existir
                {
                    if (valA == valB && valA == valC)
                    {
                        resultado = "equilatero";
                        txtbxTipo.Text = resultado.ToString();
                    }
                    else if (valA == valC || valB == valA || valB == valC)
                    {
                        resultado = "isóceles";
                        txtbxTipo.Text = resultado.ToString();
                    }
                    else // if (valA != valB && valA != valC){...}
                    {
                        resultado = "escaleno";
                        txtbxTipo.Text = resultado.ToString();
                    }
                }
            }
            else //valores branco, nulo ou não numéricos
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtbxA.Text = "";
            txtbxB.Text = "";
            txtbxC.Text = "";
            txtbxTipo.Text = "";
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
