using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }
        
        private void btnVerifNum_Click(object sender, EventArgs e)
        {
            string SuperTexto = rcTxtBx.Text;
            int QtdNumeric = 0;
            for(int count = 0; count < rcTxtBx.Text.Length; count++) //for conta os caracteres 
            {                                                        // da richTextBox
                if (char.IsNumber(SuperTexto[count]))
                {
                    QtdNumeric++; // conta os numéricos(se houver)
                }
            }
            MessageBox.Show("Número de caracteres numéricos: " + QtdNumeric);
        }
        private void btnVerifLetras_Click(object sender, EventArgs e)
        {
            string SuperTexto = rcTxtBx.Text;
            int QtdLetras = 0, count = 0;

            foreach (char letra in SuperTexto)
            {
                if (char.IsLetter(SuperTexto[count]))
                {
                    QtdLetras++; // conta as letras(se houver)
                    count++;
                }
                else //passa para próxima coordenada sem agregar QtdLetras
                {
                    count++;
                }
            }
            MessageBox.Show("Número de caracteres alfabéticos: " + QtdLetras);
        }

        private void btnVerifEspBranco_Click(object sender, EventArgs e)
        {
            string SuperTexto = rcTxtBx.Text;
            int count = 0, Espaco = 0;

            while(Espaco == 0 && count < SuperTexto.Length) //conta até dar o tamanho da string
            {
                if (!char.IsWhiteSpace(SuperTexto[count]))
                {
                    count++;
                }
                else if (char.IsWhiteSpace(SuperTexto[count]))
                {
                    Espaco = count + 1; // conta as posiçoes(até achar " ")
                }
            }
            if (Espaco == 0)
            {
                MessageBox.Show("Não existe espaço em branco no texto");
            }
            else
            {
                MessageBox.Show("Número da coordenada do espaço em branco: " + Espaco);
            }
        }
    }
}
