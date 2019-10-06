﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questão_3
{
    public partial class Receita : Form
    { 
        public Receita()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (escolha.SelectedIndex == 0)
            {
                txtValorproducao.Enabled = false;
                txtvalorvendas.Enabled = false;
                txtCodigoSetor.Enabled = false;
                txtsalario.Enabled = false;
                TxtAjuda.Enabled = false;

                txtvalorcredito.Enabled = true;
                txtvalordividas.Enabled = true;
            }

            if (escolha.SelectedIndex == 1)
            {
                txtvalorcredito.Enabled = false;
                txtvalordividas.Enabled = false;
                TxtAjuda.Enabled = false;
                txtValorproducao.Enabled = false;

                txtvalorvendas.Enabled = true;
                txtCodigoSetor.Enabled = true;
                txtsalario.Enabled = true;
            }

            if(escolha.SelectedIndex == 2)
            {
                txtvalorcredito.Enabled = false;
                txtvalordividas.Enabled = false;
                TxtAjuda.Enabled = false;
                txtvalorvendas.Enabled = false;

                txtValorproducao.Enabled = true;
                txtCodigoSetor.Enabled = true;
                txtsalario.Enabled = true;
            }

            if (escolha.SelectedIndex == 3)
            {
                txtValorproducao.Enabled = false;
                txtvalorvendas.Enabled = false;
                txtvalordividas.Enabled = false;
                txtvalorcredito.Enabled = false;

                TxtAjuda.Enabled = true;
                txtsalario.Enabled = true;
                txtCodigoSetor.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsalario_Click(object sender, EventArgs e)
        {
            txtsalario.Text = "";
        }

        private void txttelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtAjuda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValorproducao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtvalorvendas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtvalorcredito_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtvalordividas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnome_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
        }

        private void txttelefone_Click(object sender, EventArgs e)
        {
            txttelefone.Text = "";
        }

        private void txtendereco_Click(object sender, EventArgs e)
        {
            txtendereco.Text = "";
        }

        private void TxtAjuda_Click(object sender, EventArgs e)
        {
            TxtAjuda.Text = "";
        }

        private void txtValorproducao_Click(object sender, EventArgs e)
        {
            txtValorproducao.Text = "";
        }

        private void txtvalorvendas_Click(object sender, EventArgs e)
        {
            txtvalorvendas.Text = "";
        }

        private void txtvalorcredito_Click(object sender, EventArgs e)
        {
            txtvalorcredito.Text = "";
        }

        private void txtvalordividas_Click(object sender, EventArgs e)
        {
            txtvalordividas.Text = "";

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "Nome";
            txtendereco.Text = "Endereco";
            txttelefone.Text = "Telefone";
            txtvalorcredito.Text = "Valor do Credito";
            txtvalordividas.Text = "Valor da Divida";
            txtCodigoSetor.Text = "Codigo do Setor";
            txtsalario.Text = "Salario Bruto";
            TxtAjuda.Text = "Valor Ajuda de Custo";
            txtValorproducao.Text = "Valor da Produção";
            txtvalorvendas.Text = "Valor das Vendas";
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

            if (escolha.SelectedIndex == 0)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.SetValorCredito(Convert.ToDouble(txtvalorcredito.Text));
                fornecedor.SetValorDivida(Convert.ToDouble(txtvalordividas.Text));
                MessageBox.Show("O saldo correspondente aos valores indicados é " + fornecedor.ObterSaldo());
            }

            if (escolha.SelectedIndex == 1)
            {
                Vendedor vendedor = new Vendedor();
                vendedor.setSalarioBase(Convert.ToDouble(txtsalario.Text));
                vendedor.setValorVendas(Convert.ToDouble(txtvalorvendas.Text));
                double comissao = vendedor.CalcularComissao(), salario = vendedor.CalcularSalario(), INSS = vendedor.CalcularValorInss();
                MessageBox.Show("Salario: " + salario + "\n" + "Comissão: " + comissao + "\n" + "Contribuição ao Inss: " + INSS);
                
            }

            if (escolha.SelectedIndex == 2)
            {
                Operario operario = new Operario();
                operario.setSalarioBase(Convert.ToDouble(txtsalario.Text));
                operario.setValorProducao(Convert.ToDouble(txtValorproducao.Text));
                double comissao = operario.CalcularComissao(),salario = operario.CalcularSalario(), INSS = operario.CalcularValorInss();
                MessageBox.Show("Salario: " + salario + "\n" + "Comissão: " + comissao + "\n" + "Contribuição ao Inss: " + INSS);
            }

            if (escolha.SelectedIndex == 3)
            {
                Administrador ADM = new Administrador();
                ADM.SetAjudaDeCusto(Convert.ToDouble(TxtAjuda.Text));
                ADM.setSalarioBase(Convert.ToDouble(txtsalario.Text));
                double  INSS = ADM.CalcularValorInss(), salario = ADM.CalcularSalario(), ajudadecusto = ADM.getAjudaDeCusto();
                MessageBox.Show("Salario: " + salario + "\n" + "Ajuda de Custo: " + ajudadecusto + "\n" + "Contribuição ao Inss: " + INSS);
            }

        }

        private void txtCodigoSetor_Click(object sender, EventArgs e)
        {
            txtCodigoSetor.Text = "";
        }
    }
}
