using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para calcular as somas necessárias:");
        int x = int.Parse(Console.ReadLine());

        if (x <= 0 || x >= 100000)
        {
            Console.WriteLine("O número inserido não está dentro do intervalo permitido.");
        }
        else
        {
            Console.WriteLine($"Para alcançar o número {x}, você deve somar:");

            int numeroAtual = 1;
            int soma = 0;

            while (soma < x)
            {
                Console.WriteLine($"{numeroAtual} + {x - soma - numeroAtual}");
                soma += numeroAtual;
                numeroAtual++;
            }
        }
    }
}
 
