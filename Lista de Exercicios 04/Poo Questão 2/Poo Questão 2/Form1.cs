using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_Questão_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ()
            {

            }
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            soma adicao = new soma();
            lbl_resultado.Text = Convert.ToString(adicao.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
            lbl_operador.Text = "+";
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            subtracao subtrai = new subtracao();
            lbl_resultado.Text = Convert.ToString(subtrai.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
            lbl_operador.Text = "-";
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            multiplicacao multiplicar = new multiplicacao();
            lbl_resultado.Text = Convert.ToString(multiplicar.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
            lbl_operador.Text = "x";
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            divisao dividir = new divisao();
            lbl_resultado.Text = Convert.ToString(dividir.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
            lbl_operador.Text = "/";
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            CalculadoraCientifica raiz = new CalculadoraCientifica();
            lbl_resultado.Text = Convert.ToString(raiz.Calcularaiz(Convert.ToDouble(txt_Segundonumero.Text)));
            lbl_operador.Text = "√";
            txt_Primeironumero.Visible = false; 
        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            CalculadoraCientifica potencia = new CalculadoraCientifica();
            lbl_resultado.Text = Convert.ToString(potencia.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
        }
    }
}
