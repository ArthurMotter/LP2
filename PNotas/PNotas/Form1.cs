using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PNotas
{
    public partial class Form1 : Form
    {
        char[,] matrizNota = new char[15, 10];
        char[] vetorRespostas = new char[10] { 'A', 'B', 'C', 'D', 'E', 'A', 'B', 'C', 'D', 'E' };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string texto;
           
            for(int i = 0; i < 15; i++)
            {

                for(int j = 0; j < 10; j++)
                {
                    texto = Interaction.InputBox("digite uma letra", "lista de notas");
                     if((texto.ToUpper()).Equals("A") || (texto.ToUpper()).Equals("B") ||
                        (texto.ToUpper()).Equals("C") || (texto.ToUpper()).Equals("D") ||
                        (texto.ToUpper()).Equals("E"))
                    {
                        matrizNota[i, j] = Convert.ToChar(texto);
                    }
                    else
                    {
                        MessageBox.Show("Entrada invalida");
                        j--;
                    }
                    for(int k = 0; k < 15; k++)
                    {
                        for( int l = 0; l < 10; l++)
                        {
                            if(matrizNota[k,l].Equals(vetorRespostas[l]))
                            {
                                MessageBox.Show("foi");
                            }
                        }
                    }
                }
            }
        }

        private void LstBoxLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(matrizNota[i,j] == vetorRespostas[j])
                    {
                        lstBoxLista.Text = "o aluno " + i + " acertou a questão " + j + " era "
                        + vetorRespostas[j] + " escolheu " + matrizNota[i, j];
                    }
                    else
                    {
                        lstBoxLista.Text = "o aluno " + i + " errou a questão " + j + " era "
                        + vetorRespostas[j] + " escolheu " + matrizNota[i, j];
                    }
                }
            }
        }
    }
}
