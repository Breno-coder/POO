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
    public partial class Resultado : Form
    {
        
        double Imc = 0;
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            Paciente resul = new Paciente();
            lblnome.Text = resul.getnome();
            Imc = resul.CalculaIMC;
            lblClassificacaodoIMC = resul.ClassificaImc(Imc);
        }

        private void lblnome_Click(object sender, EventArgs e)
        {
            lblnome.Text = resul.getnome();
        }

        private void lblIMC_Click(object sender, EventArgs e)
        {
            
        }

        private void lblClassificacaodoIMC_Click(object sender, EventArgs e)
        {

        }
    }
}
