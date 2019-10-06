using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    public class Vendedor : Empregado
    {
        double ValorVendas, Comissao;
        public Vendedor()
        { }

        public void setValorVendas(double valorvendas)
        {
            ValorVendas = valorvendas;
        }

        public void setSalarioBase(double salariobase)
        {
            SalarioBase = salariobase;

        }

        public double CalcularComissao()
        {
            return Comissao = (ValorVendas * 0.05);
        }

        public override double CalcularSalario()
        {
            return (SalarioBase + Comissao) - ValorInss;
        }
    
        public override double CalcularValorInss()
        {
            return ValorInss = (SalarioBase * 0.09); 
        }
        
       
    }
}
