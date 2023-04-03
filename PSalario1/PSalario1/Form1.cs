using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario1
{
    public partial class Form1 : Form
    {
        string EstCivil, Nome, Sexo;
        int Filhos;
        double SalFunc = 0, SalLiq = 0, SalFamil = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double AliquotaINSS, AliquotaIRPF, SalINSS, SalIRPF;

            if ((double.TryParse(txtBxSalBruto.Text, out SalFunc)) &&
                int.TryParse(NmUpDn.Text, out Filhos))
            {
                //INSS
                if (SalFunc < 800.48) //7.65%
                {
                    AliquotaINSS = 7.65;
                    SalINSS = (SalFunc * AliquotaINSS) / 100.0;
                }
                else if (SalFunc >= 800.48 && SalFunc < 1050.01) //8.65%
                {
                    AliquotaINSS = 8.65;
                    SalINSS = (SalFunc * AliquotaINSS) / 100.0;
                }
                else if (SalFunc >= 1050.01 && SalFunc < 1400.78) //9.00%
                {
                    AliquotaINSS = 9.0;
                    SalINSS = (SalFunc * AliquotaINSS) / 100.0;
                }
                else if (SalFunc >= 1400.78 && SalFunc <= 2801.56) //11.00%
                {
                    AliquotaINSS = 11.0;
                    SalINSS = (SalFunc * AliquotaINSS) / 100.0;
                }
                else //R$308.17 (teto)
                {
                    AliquotaINSS = 308.17;
                    SalINSS = (SalFunc - AliquotaINSS);
                }
                txtBxAliqINSS.Text = AliquotaINSS.ToString() + " %";
                txtBxDescINSS.Text = "R$ " + SalINSS.ToString();

                //IRPF
                if (SalFunc > 0 && SalFunc < 1247.13) //isento
                {
                    AliquotaIRPF = 0.0;
                    SalIRPF = 0.0;
                }
                else if (SalFunc >= 1247.13 && SalFunc < 2512.08) //15.00%
                {
                    AliquotaIRPF = 15.0;
                    SalIRPF = (SalFunc * AliquotaIRPF) / 100.0;
                }
                else //27.50%
                {
                    AliquotaIRPF = 27.5;
                    SalIRPF = (SalFunc * AliquotaIRPF) / 100.0;
                }
                txtBxAliqIRPF.Text = AliquotaIRPF.ToString() + " %";
                txtBxDescIRPF.Text = "R$ " + SalIRPF.ToString();

                //salario Familia
                if (SalFunc < 435.53)
                {
                    SalFamil = (Filhos * 22.33);
                }
                else if (SalFunc >= 435.53 && SalFunc < 654.62)
                {
                    SalFamil = (Filhos * 15.74);
                }
                else
                {
                    SalFamil = 0.0;
                }
                txtBxSalFamil.Text = "R$ " + SalFamil.ToString();

                //Salário Liquido
                SalLiq = (SalFunc-SalINSS-SalIRPF) + SalFamil;
                txtBxSalLiq.Text = "R$ " + SalLiq.ToString();
            }
            //preenche os dados
            lblDados.Text = " Os descontos do Salário de " + Sexo + " " + Nome +
                " que é " + EstCivil + " e que tem: " + Filhos + " filho(s)";
        }
        private void RbtnSexM_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Sr";
        }

        private void TxtBxNomFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)
                || char.IsControl(e.KeyChar))
            {
                Nome = TxtBxNomFunc.Text; //é letra e/ou espaço em branco
            }
            else
            {
                MessageBox.Show("valor inválido!");
            }
        }

        private void RbtnSexF_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "Sra";
        }
        private void CkBxEstCivil_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBxEstCivil.Checked == true) //define estado civil da pessoa
            {
                EstCivil = "Casado(a)";
            }
            else
            {
                EstCivil = "Solteiro(a)";
            }
        }
        private void NmUpDn_Validated(object sender, EventArgs e)
        {
            if (NmUpDn.Value < 0)
            {
                MessageBox.Show("valor inválido");
            }
            else
            {
                Filhos += Filhos;
            }
        }
        private void TxtBxSalBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) 
                || char.IsControl(e.KeyChar))
            {
                //é número e/ou pontuação
            }
            else
            {
                MessageBox.Show("insira um valor Válido!");
            }
        }
    }
}
