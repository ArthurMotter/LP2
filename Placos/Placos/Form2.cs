using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Placos
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnEspBranc_Click(object sender, EventArgs e)
        {
            string SuperTexto = rcTxtBx.Text;
            int count = 0, Espaco = 0;

            while (Espaco < SuperTexto.Length && count < SuperTexto.Length) //conta até dar o tamanho da string
            {
                if (char.IsWhiteSpace(SuperTexto[count]))
                {
                    count++;
                    Espaco++;
                }
                else 
                {
                    count++;
                }
            }
            if (Espaco == 0)
            {
                MessageBox.Show("Não existe espaço em branco no texto");
            }
            else
            {
                MessageBox.Show("Número de espaços em branco: " + Espaco);
            }
        }

        private void BtnVerifRs_Click(object sender, EventArgs e)
        {
            string SuperTexto = rcTxtBx.Text;
            int QtdR = 0, count = 0;
            char letraR = 'r';

            foreach (char letra in SuperTexto)
            {
                if (char.IsLetter(SuperTexto[count]))
                {
                    Convert.ToChar((SuperTexto[count]));
                    if (!char.ToLower(SuperTexto[count]).Equals(letraR))
                    {
                        count++;
                    }
                    else
                    {
                        QtdR++;
                        count++;
                    }
                }
                else
                {
                    count++;
                }
            }
            MessageBox.Show("Número de R's: " + QtdR);
        }

        private void BtnParLetras_Click(object sender, EventArgs e)
        {
            int numPares = 0;
            for (var i = 0; i < rcTxtBx.Text.Length -1; i++) //lê o componente
            {
                if (rcTxtBx.Text[i] == rcTxtBx.Text[i + 1]) //compara a letra anterior
                {
                    numPares += 1;
                }
            }
            MessageBox.Show("número de pares de letras:" + numPares.ToString());
        }
    }
}
