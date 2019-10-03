using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Vendedor : Empregado
    {
        double ValorVendas, Comissao;
        Vendedor()
        { }

        public double CalcularComissao()
        {
            return Comissao = ValorVendas * (5/100);
        }

        public override double CalcularValorInss()
        {
            return ValorInss = SalarioBase * (9 / 100); ;
        }

        public override double CalcularSalario()
        {
            return (SalarioBase + Comissao) - ValorInss;
        }
    }
}
