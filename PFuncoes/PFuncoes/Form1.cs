using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Soma1() //função
        {
            Double resultado = 1 + 2;
            MessageBox.Show(resultado.ToString());
        }
        private void Button1_Click(object sender, EventArgs e) //call
        {
            Soma1();
        }

        Double Soma2() //função return
        {
            Double resultado = 2 + 3;
            return resultado;
        }
        private void BtnSoma2_Click(object sender, EventArgs e) //evento
        {
            /*double x = Soma2();
            MessageBox.Show(x.ToString());*/
            MessageBox.Show(Soma2().ToString());
        }

        void Soma3(double x, double y) //função com parâmetros
        {
            x = 40;
            Double resultado = x + y;
            MessageBox.Show("o resultado é: " + resultado.ToString());
        }
        private void BtnSoma3_Click(object sender, EventArgs e) //evento com parâmetros
        {
            double a = 10;
            double b = 20;
            Soma3(a, b);
            MessageBox.Show("valor de a: " + a + "\nvalor de b: " + b);
        }

        double Soma4(double x, double y) //função com parâmetros e retorno
        {
            Double resultado = x + y;
            return resultado;
        }
        private void BtnSoma4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Soma4(10, 20).ToString());
        }

        void Soma5(ref double resultado, ref double a) //função com parâmetros por referência
        {
            a = 40;
            resultado = 2 + 3;
        }
        private void BtnSoma5_Click_1(object sender, EventArgs e) //evento com parâmetros por referência
        {
            double a = 10;
            double b = 20;
            Soma5(ref a,ref b);
            MessageBox.Show("valor de a: " + a + "\nvalor de b: " + b);
        }

        Double Soma6(ref double resultado) //função retorno com parâmetros por referência
        {
            resultado = 2 + 3;
            return resultado;
        }
        private void BtnSoma6_Click(object sender, EventArgs e) //evento retorno com parâmetros por referência
        {
            double r = 0;
            double x = Soma6(ref r);
            MessageBox.Show(x.ToString());
            MessageBox.Show(r.ToString());
        }

        void Soma7(out double resultado) //função com parâmetros de saída
        {
            //MessageBox.Show(resultado.ToString());
            resultado = 2 + 3;
        }
        private void BtnSoma7_Click(object sender, EventArgs e)
        {
            double a = 50;
            Soma7(out a);
            MessageBox.Show(a.ToString());
        }

        Double Soma8(out double resultado) //função retorno com parâmetros de saída
        {
            resultado = 2 + 3;
            return resultado;
        }
        private void BtnSoma8_Click(object sender, EventArgs e) //evento de retorno com parâmetros de saída
        {
            double a = 50;
            MessageBox.Show(Soma8(out a).ToString());
            MessageBox.Show(a.ToString());
        }
        void Soma9(out double retorno, double x,
            double y, double z = 0) //função com parâmetros de saída e parametro opcional
        {
            if (z > 0)
                retorno = (x + y + z) / 3;
            else
                retorno = (x + y) / 2;
        }
        private void BtnSoma9_Click(object sender, EventArgs e)
        {
            double r = 0;
            Soma9(out r, 10, 20, 30);
            //se não passar opcional volta 15
            //se passar opcional volta 20
            MessageBox.Show(r.ToString());
        }
    }
}