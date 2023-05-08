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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnPalindr_Click(object sender, EventArgs e)
        {
            int Palindr = 0;
            char[] vetor = textBox1.Text.ToCharArray();
            string palavra = textBox1.Text;

            Array.Reverse(vetor);
            string inversor = "";
            foreach (char c in vetor)
            {
                inversor += c; 
            }

            char[] inverte = inversor.ToCharArray();
            Array.Reverse(inverte);

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == inverte[i])
                {
                    Palindr++;
                }
            }  

            if (Palindr == vetor.Length)
            {
                MessageBox.Show("é palíndromo");
            }
            else
            {
                MessageBox.Show("não é palíndromo");
            }
        }
    }
}
