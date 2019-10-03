using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Operario : Empregado
    {
        double ValorProducao, Comissao;
        Operario()
        { }

        public double CalcularComissao()
        {
            return Comissao = ValorProducao * (0.5/100);
        }

        public override double CalcularValorInss()
        {
            return ValorInss = SalarioBase * (8 / 100); ;
        }

        public override double CalcularSalario()
        {
            return (SalarioBase + Comissao) - ValorInss;
        }
    }
}
