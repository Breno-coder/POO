using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico
    {
        protected string Registro;
        protected string Nome;
        public DateTime DataNascimento;

        protected int CalculaIdade()
        {
            int Idade = DateTime.Now.Year - DataNascimento.Year;

            return Idade;
        }
    }
}
