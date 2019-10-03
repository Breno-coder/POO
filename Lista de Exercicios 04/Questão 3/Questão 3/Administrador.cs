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

        Administrador()
        { }
        public void SetAjudaDeCusto(double ajudadecusto)
        {
            AjudaDeCusto = ajudadecusto;
        }

        public override double CalcularValorInss()
        {
           
            return  ValorInss = SalarioBase * (11 / 100);
        }

        public override double CalcularSalario()
        {
            return (SalarioBase + AjudaDeCusto) - ValorInss;
        }
    }
}
