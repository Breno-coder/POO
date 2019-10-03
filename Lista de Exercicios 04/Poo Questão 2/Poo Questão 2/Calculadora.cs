using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Questão_2
{
    abstract class Calculadora
    {
        double Primeironumero, Segundonumero;

        abstract public double calcular(double Primeironumero, double Segundonumero);
    }
        

    class soma : Calculadora
    {
        public soma()
        {
        }
        public override double calcular(double Primeironumero, double Segundonumero)
        {
            return Primeironumero + Segundonumero;
        }
    }

    class subtracao : Calculadora
    {
        public subtracao()
        {
        }
        public override double calcular(double Primeironumero, double Segundonumero)
        {
            return Primeironumero - Segundonumero;
        }
    }

    class divisao : Calculadora
    {
        public divisao()
        {
        }
        public override double calcular(double Primeironumero, double Segundonumero)
        {
            return Primeironumero / Segundonumero;
        }
    }

    class multiplicacao : Calculadora
    {
        public multiplicacao()
        {
        }
        public override double calcular(double Primeironumero, double Segundonumero)
        {
            return Primeironumero * Segundonumero;
        }
    }
    
    class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica()
        {
        }
        public override double calcular(double Primeironumero, double Segundonumero)
        {
            return Math.Pow(Primeironumero, Segundonumero);
        }

        public double Calcularaiz(double Numero)
        {
            return Math.Sqrt(Numero);
        }

    }
}

