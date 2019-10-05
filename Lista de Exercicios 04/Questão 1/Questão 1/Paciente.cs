using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1
{
    class Paciente
    {
        private string Nome, Sobrenome, Sexo;
        private int Idade, Peso;
        private double PercentualGordura, Altura;

        public string getnome()
        {
            return Nome;
        }

        public void setnome(string nome)
        {
            Nome = nome;
        }

        public string getsobrenome()
        {
            return Sobrenome;
        }

        public void setsobrenome(string sobrenome)
        {
            Sobrenome = sobrenome;
        }

        public string getsexo()
        {
            return Sexo;
        }

        public void setsexo(string sexo)
        {
            Sexo = sexo;
        }

        public int getidade()
        {
            return Idade;
        }

        public void setidade(int idade)
        {
            Idade = idade;
        }

        public int getpeso()
        {
            return Peso;
        }

        public void setpeso(int peso)
        {
            Peso = peso;
        }

        public double getaltura()
        {
            return Altura;
        }

        public void setaltura(double altura)
        {
            Altura = altura;
        }

        public double CalculaIMC()
        {
            double Imc = Peso / (Math.Pow( Altura, 2));

            return Imc;
        }

        public string ClassificaImc(double Imc)
        {
            string classificacaodoImc = string.Empty;

            if (Imc < 18.5)
            {
                classificacaodoImc = "Magreza";
            }


            if (Imc > 18.5 && Imc < 24.9)
            {
                classificacaodoImc = "Normal";
            }


            if (Imc > 24.9 && Imc < 30)
            {
                classificacaodoImc = "Sobrepeso";
            }


            if (Imc > 30)
            {
                classificacaodoImc = "Obesidade";
            }

            return classificacaodoImc;
        }

        public string ClassificaPercentualGordura(double percentualGordura, int idade, string sexo)
        {
            string gorduracorporal = string.Empty;
            if (sexo == "Masculino")
            {
                if (idade > 20 && idade < 29)
                {
                    if (percentualGordura < 11)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 11 && percentualGordura < 13)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 14 && percentualGordura < 20)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 21 && percentualGordura < 23)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 23)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }

                if (idade > 30 && idade < 39)
                {
                    if (percentualGordura < 12)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 12 && percentualGordura < 14)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 15 && percentualGordura < 21)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 22 && percentualGordura < 24)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 24)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }

                if (idade > 40 && idade < 49)
                {
                    if (percentualGordura < 14)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 14 && percentualGordura < 16)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 17 && percentualGordura < 23)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 24 && percentualGordura < 26)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 26)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }

                if (idade > 50 && idade < 59)
                {
                    if (percentualGordura < 15)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 15 && percentualGordura < 17)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 18 && percentualGordura < 24)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 25 && percentualGordura < 27)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 27)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }
                return "0";
            }

            if (sexo == "Feminino")
            {
                if (idade > 20 && idade < 29)
                {
                    if (percentualGordura < 16)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 16 && percentualGordura < 19)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 20 && percentualGordura < 28)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 29 && percentualGordura < 31)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 31)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }

                if (idade > 30 && idade < 39)
                {
                    if (percentualGordura < 17)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 17 && percentualGordura < 20)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 21 && percentualGordura < 29)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 30 && percentualGordura < 32)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 32)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }

                if (idade > 40 && idade < 49)
                {
                    if (percentualGordura < 18)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 18 && percentualGordura < 21)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 22 && percentualGordura < 30)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 31 && percentualGordura < 33)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 33)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }

                if (idade > 50 && idade < 59)
                {
                    if (percentualGordura < 19)
                    {
                        gorduracorporal = "Atleta";
                    }

                    if (percentualGordura > 19 && percentualGordura < 22)
                    {
                        gorduracorporal = "Bom";
                    }

                    if (percentualGordura > 23 && percentualGordura < 31)
                    {
                        gorduracorporal = "Normal";
                    }

                    if (percentualGordura > 32 && percentualGordura < 34)
                    {
                        gorduracorporal = "Elevado";
                    }

                    if (percentualGordura > 34
)
                    {
                        gorduracorporal = "Muito Elevado";
                    }
                }
                return "0";
            }
    
            return gorduracorporal;
        }
    }
}
