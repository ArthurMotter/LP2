using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemov_Click(object sender, EventArgs e)
        {
            int Posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            //ex:   0123456789
            //ss em assessoria (1 e 2, 4 e 5) 
            while (Posicao >= 0) //pega e compara tds os caracteres
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, Posicao) +
                txtPalavra2.Text.Substring(Posicao + txtPalavra1.TextLength,
                txtPalavra2.Text.Length - txtPalavra1.TextLength-Posicao);

                Posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void BtnReplac_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text,"");
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);
            string inversor = "";
            foreach (char c in vetor)
            {
                inversor += c;
            }
            MessageBox.Show(inversor);
        }
    }
}
