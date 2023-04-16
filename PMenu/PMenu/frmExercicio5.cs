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

namespace PMenu
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnRandomic_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            int Numero1 = Convert.ToInt16(txtNumero1.Text);
            int Numero2 = Convert.ToInt16(txtNumero2.Text);
            int TamMax = Numero2;
            int TamMin = Numero1;

            if (Numero1 > Numero2) //inverte os valores se Numero1 > Numero2
            {
                TamMax = Numero1;
                TamMin = Numero2;
            }
            int NumSort = Aleatorio.Next(TamMin,TamMax + 1); //realiza a geração randomica

            for (int Count = 0; Count < TamMax; Count++)
            {
                Aleatorio.Next(TamMin, TamMax + 1); //entre o menor número e o maior número
            }
            if (Numero1 == NumSort)
            {
                MessageBox.Show("Número sorteado: " + Numero1);
            }
            else if (Numero2 == NumSort)
            {
                MessageBox.Show("Número sorteado: " + Numero2);
            }
            else
            {
                MessageBox.Show("Número sorteado: " + NumSort);
            }
        }
    }
}
