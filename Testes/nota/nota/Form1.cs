using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nota
{
    public partial class Form1 : Form
    {
        float[] notas = new float[4];
        float notamaior = -100, notamenor = 100, media = 0;

        public Form1()
               {
                   InitializeComponent();
               }
        private void nota2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nota3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtmaiornota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmedia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nota4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            atribuirnotas();
            calculamedia();
            calculanotamaior();
            calculanotamenor();
        }

        private void nota1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void calculamedia()
        {
            float soma=0;
            for(int i=0; i<4; i++)
            {
                soma = notas[i] + soma; 
            }
            soma = soma / 4;
            txtmedia.Text = Convert.ToString(soma);
        }

        private void btnlimpa_Click(object sender, EventArgs e)
        {
            for(int i=0; i<4; i++)
            {
                notas[i] = 0;
            }
            txtmaiornota.Text = String.Empty;
            txtmenornota.Text = String.Empty;
            txtmedia.Text = String.Empty;

            nota1.Text = string.Empty;
            nota2.Text = string.Empty;
            nota3.Text = string.Empty;
            nota4.Text = string.Empty;
        }

        public void calculanotamaior()
        {
            float notamaior = 0;
            for(int i=0; i<4; i++)
            {
                if(notas[i] >= notamaior)
                {
                    notamaior = notas[i];
                }
                txtmaiornota.Text = Convert.ToString(notamaior);
            }
        }

        private void nota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                //nota1.Text = string.Empty;

            }
        }

        private void nota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) )
            {
                if (e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                //nota1.Text = string.Empty;
                
            }
        }

        private void nota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                //nota1.Text = string.Empty;

            }
        }

        private void nota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int pontos = 0;
            if (!char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                    {
                        pontos++;
                        if (pontos > 1)
                        {
                            e.Handled = true;
                        }
                    }
                    
                }
                //nota1.Text = string.Empty;

            }
        }

        public void calculanotamenor()
        {
            float notamenor = 100;
            for (int i = 0; i < 4; i++)
            {
                if (notas[i] < notamenor)
                {
                    notamenor = notas[i];
                }
                txtmenornota.Text = Convert.ToString(notamenor);
            }
        }

        public void atribuirnotas()
        {
            notas[0] = float.Parse(nota1.Text);
            notas[1] = float.Parse(nota2.Text);
            notas[2] = float.Parse(nota3.Text);
            notas[3] = float.Parse(nota4.Text);
        }
    }
}
