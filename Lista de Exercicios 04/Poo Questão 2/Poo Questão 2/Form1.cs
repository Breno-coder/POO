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
            
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            soma adicao = new soma();
            try
            {
                    lbl_resultado.Text = Convert.ToString(adicao.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                    lbl_operador.Text = "+";
                    
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
                subtracao subtrai = new subtracao();
                lbl_resultado.Text = Convert.ToString(subtrai.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "-";
                
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
                multiplicacao multiplicar = new multiplicacao();
                lbl_resultado.Text = Convert.ToString(multiplicar.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "x";
                 

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
                divisao dividir = new divisao();
                lbl_resultado.Text = Convert.ToString(dividir.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                lbl_operador.Text = "/";


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
                CalculadoraCientifica raiz = new CalculadoraCientifica();
                lbl_resultado.Text = Convert.ToString(raiz.Calcularaiz(Convert.ToDouble(txt_Segundonumero.Text)));
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
                CalculadoraCientifica potencia = new CalculadoraCientifica();
                lbl_resultado.Text = Convert.ToString(potencia.calcular(Convert.ToDouble(txt_Primeironumero.Text), Convert.ToDouble(txt_Segundonumero.Text)));
                

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
        }
    }
}
