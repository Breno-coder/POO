using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Questão_2
{
    public class Calculadora
    {
        double Primeironumero, Segundonumero;

        public double somar(double Primeironumero, double Segundonumero)
        {
            return Primeironumero + Segundonumero;
        }

        public double subtrair(double Primeironumero, double Segundonumero)
        {
            return Primeironumero - Segundonumero;
        }

        public double dividir(double Primeironumero, double Segundonumero)
        {
            return Primeironumero / Segundonumero;
        }

        public double multiplicar(double Primeironumero, double Segundonumero)
        {
            return Primeironumero * Segundonumero;
        }
    }

    class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica()
        {
        }
        public double calcularpotencia(double Primeironumero, double Segundonumero)
        {
            return Math.Pow(Primeironumero, Segundonumero);
        }

        public double calcularaiz(double Numero)
        {
            return Math.Sqrt(Numero);
        }

    }
}

