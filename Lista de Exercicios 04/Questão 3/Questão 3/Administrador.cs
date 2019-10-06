using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    class Administrador : Empregado
    {
        double AjudaDeCusto;

        public Administrador()
        { }

        public void setSalarioBase(double salariobase)
        {
            SalarioBase = salariobase;

        }

        public void SetAjudaDeCusto(double ajudadecusto)
        {
            AjudaDeCusto = ajudadecusto;
        }

        public double getAjudaDeCusto()
        {
            return AjudaDeCusto;
        }

        public override double CalcularValorInss()
        {
           
            return  (ValorInss = SalarioBase * 0.11);
        }

        public override double CalcularSalario()
        {
            return ((SalarioBase + AjudaDeCusto) - ValorInss);
        }
    }
}
