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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio1 objFrm2 = new frmExercicio1();
            objFrm2.MdiParent = this;
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();
        }

        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objFrm3 = new frmExercicio2();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }

        private void Exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objFrm4 = new frmExercicio3();
            objFrm4.MdiParent = this;
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();
        }

        private void Exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 objFrm5 = new frmExercicio4();
            objFrm5.MdiParent = this;
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();
        }
    }
}
