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
        Paciente resul = new Paciente();
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            lblnome.Text = resul.getnome();
        }

        private void lblnome_Click(object sender, EventArgs e)
        {
            lblnome.Text = resul.getnome();
        }
    }
}
