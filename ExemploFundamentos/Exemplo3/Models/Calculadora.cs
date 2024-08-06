using System;

namespace Exemplo3.Models
{
    internal class Calculadora
    {
        public void Somar(int x, int y)
        {
            double resultado = x + y;
            Console.WriteLine($"{x} + {y} = {resultado}");
        }

        public void Subtrair(int x, int y)
        {
            double resultado = x - y;
            Console.WriteLine($"{x} - {y} = {resultado}");
        }

        public void Multiplicar(int x, int y)
        {
            double resultado = x * y;
            Console.WriteLine($"{x} * {y} = {resultado}");
        }

        public void Dividir(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Não é possível dividir por zero!");
            }

            double resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado}");
        }

        public void Potenciacao(int x, int y)
        {
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {resultado}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double resultado = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(resultado, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double resultado = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}º = {Math.Round(resultado, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double resultado = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(resultado, 4)}");
        }

        public void Modulo(int x, int y)
        {
            double resultado = x % y;
            Console.WriteLine($"{x} % {y} = {resultado}");
        }
    }
}
