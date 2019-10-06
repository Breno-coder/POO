using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    public class Operario : Empregado
    {
        double ValorProducao, Comissao;
        public Operario()
        { }

        public void setValorProducao(double valorproducao)
        {
            ValorProducao = valorproducao;
        }

        public void setSalarioBase(double salariobase)
        {
            SalarioBase = salariobase;

        }

        public double CalcularComissao()
        {
            return (Comissao = ValorProducao * 0.005);
        }

        public override double CalcularValorInss()
        {
            return (ValorInss = SalarioBase * 0.08); ;
        }

        public override double CalcularSalario()
        {
            return ((SalarioBase + Comissao) - ValorInss);
        }
    }

}
