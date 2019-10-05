using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_3
{
    public class Fornecedor : Pessoa
    {
        double ValorCredito, ValorDivida;

        public Fornecedor()
        { }
        

        public void SetValorCredito(double valorcredito)
        {
            ValorCredito = valorcredito;
        }

        public void SetValorDivida(double valordivida)
        {
            ValorDivida = valordivida;

        }

        public double GetValorCredito()
        {
            return ValorCredito;
        }

        public double GetValorDivida()
        {
            return ValorDivida;
        }

        public double ObterSaldo()
        {
            return ValorCredito - ValorDivida;
        }
    }
}
