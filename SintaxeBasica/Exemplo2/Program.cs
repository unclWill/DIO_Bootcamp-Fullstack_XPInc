namespace Exemplo2;

class Program
{
    static void Main(string[] args)
    {
        // Convertendo de maneira segura.
        string a = "15-";

        // A variável de saída pode ser declarada previamente ou omitida e declarada diretamente no corpo do TryParse.
        // int b = 0; 

        int.TryParse(a , out int b);

        Console.WriteLine(b);
        Console.WriteLine("Conversão realizada com sucesso!");
    }
}
