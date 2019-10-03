using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    abstract class Empregado : Pessoa
    {
        int CodigoSetor;
        public double SalarioBase, ValorInss;

        abstract public double CalcularValorInss();
        abstract public double CalcularSalario();
    }
}
