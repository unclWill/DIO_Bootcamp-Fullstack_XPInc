namespace Exemplo3;

using Exemplo3.Models;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        calc.Somar(10, 10); 
        calc.Subtrair(15, 10); 
        calc.Multiplicar(10, 10); 
        calc.Dividir(15, 10);
        calc.Potenciacao(2, 10);
        calc.Modulo(10, 3);
        calc.Seno(30);
        calc.Cosseno(30);
        calc.Tangente(30);
    }
}
