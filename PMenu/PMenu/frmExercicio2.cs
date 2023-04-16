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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnVerif_Click(object sender, EventArgs e)
        { //compara palavra 1 e palavra 2
            if (string.Compare(txtPalavra1.Text, txtPalavra2.Text, true)==0)
            {
                MessageBox.Show("são iguais");
            }
            else
            {
                MessageBox.Show("são diferentes");
            }
        }

        private void BtnInsMeio_Click(object sender, EventArgs e)
        { // insere palavra 1 no "meio" da palavra 2
            int metade = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, metade) + txtPalavra1.Text +
                txtPalavra2.Text.Substring(metade, txtPalavra2.Text.Length - metade);
        }

        private void BtnInsAst_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Insert(metade, "**");
        }
    }
}
