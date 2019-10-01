using System;

abstract public class Calculadora
{
    int Numero1, Numero2;
	public Calculadora()
	{
	}

    public void setnumero1();

    public void setnumero2();

    public float somar(float Numero1, float Numero2);
    public float subtrai(float Numero1, float Numero2);
    public float multiplicar(float Numero1, float Numero2);
    public float dividir(float Numero1, float Numero2);
}

