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
        Calculadora calcula = new Calculadora();
        CalculadoraCientifica operacao = new CalculadoraCientifica();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            try
            {
                    lbl_resultado.Text = Convert.ToString(calcula.somar(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                    lbl_operador.Text = "+";
                    txt_Primeironumero.Visible = true;
            }
            catch 
            {
                MessageBox.Show("Operação invalida");
            }
            
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = Convert.ToString(calcula.subtrair(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "-";
                txt_Primeironumero.Visible = true;
            }
            catch
            {
                MessageBox.Show("Operação invalida");
            }
            
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = Convert.ToString(calcula.multiplicar(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "x";
                txt_Primeironumero.Visible = true;

            }
            catch
            {
                MessageBox.Show("Operação invalida");
            }
            
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = Convert.ToString(calcula.dividir(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "/";
                txt_Primeironumero.Visible = true;

            }
            catch
            {
                MessageBox.Show("Operação invalida");
            }
            
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = Convert.ToString(operacao.Calcularaiz(Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "√";
                txt_Primeironumero.Visible = false; 
            }
            catch
            {
                MessageBox.Show("Operação invalida");
            }
            
        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_resultado.Text = Convert.ToString(operacao.Calcularpotencia(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "^";
                txt_Primeironumero.Visible = true;

            }
            catch
            {
                MessageBox.Show("Operação invalida");
            }
            
        }

        private void txt_Primeironumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Primeironumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                try
                {
                    Convert.ToDouble(this.Text);
                }
                catch
                {
                    MessageBox.Show("Formato Invalido");
                }
            }
        }

        private void txt_Segundonumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Segundonumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                try
                {
                    Convert.ToDouble(this.Text);
                }
                catch
                {
                    MessageBox.Show("Formato Invalido");
                }
            }
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txt_Primeironumero.Visible = true;
            lbl_operador.Text = "";
            lbl_resultado.Text = "";
            txt_Primeironumero.Text = "";
            txt_Segundonumero.Text = "";
        }
    }
}
