using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    abstract class Calculadora
    {
        public float calcular(float Numero1, float Numero2);
    }

    class somar : Calculadora
    {
        public override float calcular(float Numero1, float Numero2)
        {
            return Numero1 + Numero2;
        }
    }

    class subtracao : Calculadora
    {
        public override float calcular(float Numero1, float Numero2)
        {
            return Numero1 - Numero2;
        }
    }

    class multiplicacao : Calculadora
    {
        public override float calcular(float Numero1, float Numero2)
        {
            return Numero1 * Numero2;
        }
    }

    class divisao : Calculadora
    {
        public override float calcular(float Numero1, float Numero2)
        {
            return Numero1 / Numero2;
        }
    }
}
