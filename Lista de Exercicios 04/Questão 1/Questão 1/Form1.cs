using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_1
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

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.setnome(txbnome.Text);
            paciente.setsobrenome(txbsobrenome.Text);
            paciente.setidade(Convert.ToInt32(txbidade.Text));
            paciente.setsexo(escolhasexo.Text);
            paciente.setaltura(Convert.ToDouble(txbAltura.Text));
            paciente.setpeso(Convert.ToInt32(txbPeso.Text));

            double IMC = paciente.CalculaIMC();
            string Classificacaodoimc = paciente.ClassificaImc(IMC), Classificacaodopercentualdegordura = paciente.ClassificaPercentualGordura(IMC, Convert.ToInt32(txbidade.Text), escolhasexo.Text);
            MessageBox.Show("Olá " + paciente.getnome() +" o seu IMC atual é " + IMC.ToString() + ", a classificação correspondente a esse IMC é " + Classificacaodoimc + ", e o percentual de gordura correspondente é " + Classificacaodopercentualdegordura);
        }   

        private void txbnome_MouseClick(object sender, MouseEventArgs e)
        {
            txbnome.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbnome.Text = "Digite seu nome";
            txbsobrenome.Text = "Digite seu sobrenome";

            txbidade.Text = "";
            escolhasexo.Text = "Sexo";
            txbAltura.Text = "";
            txbPeso.Text = "";
        }

        private void txbsobrenome_Click(object sender, EventArgs e)
        {
            txbsobrenome.Text = "";
        }

        private void txbidade_Click(object sender, EventArgs e)
        {
            txbidade.Text = "";
        }

        private void txbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
