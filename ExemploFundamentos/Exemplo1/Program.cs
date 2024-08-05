using Exemplo1.Models;

namespace Exemplo1;

class Program
{
    public static void Main(string[] args)
    {
        // Tipos de dados.
        string apresentacao = "Olá, seja bem vindo!";
        int quantidade = 1;
        double altura = 1.83D;
        decimal preco = 1.80M;
        bool condicao = true;
        
        // Trabalhando com o tipo de data e hora.
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine($"Data Hora atual: {dataAtual:dd/MM/yyyy HH:mm}");

        Console.WriteLine(apresentacao);
        Console.WriteLine($"Valores das variável quantidade: {quantidade}");
        Console.WriteLine($"Valores das variável altura: {altura.ToString("0.00")}");
        Console.WriteLine($"Valores das variável preco: {preco:C}");
        Console.WriteLine($"Valores das variável condicao: {condicao}");

        // Instanciação de um objeto do tipo Pessoa.
        Pessoa p = new Pessoa("William", 27);
        p.Apresentar();
    }
}