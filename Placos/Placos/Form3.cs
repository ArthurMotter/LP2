using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Placos
{
    public partial class frmExercicio2 : Form
    {
        int N = 0;
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            double H = 1;

            if (int.TryParse(textBox1.Text, out N) && N > 0)
            {
                //H = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5 + ...+1 / N, utilizar instruções For.
                for (int i = 1; i <= N; i++)
                {
                    H = H + (1.0 / (i+1));
                }

                MessageBox.Show(H.ToString());
            }
            else
            {
                MessageBox.Show("não foi possivel computar");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {   
            if (textBox1.Text == "")
            {
                N = 0;
            }
            else
            {
                N = Convert.ToInt32(textBox1.Text);
            }
        }
    }
}
