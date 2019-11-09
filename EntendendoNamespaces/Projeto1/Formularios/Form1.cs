using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Medico medico = new Medico();
        Obstreta obstreta = new Obstreta();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
