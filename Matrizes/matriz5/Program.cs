using System;

namespace matriz5
{
    class Program
    {
        static void Main()
        {
           int n, i;

           Console.WriteLine("Digite um número: ");
           n = int.Parse(Console.ReadLine()!);

           int[] vetor = new int[n];

           for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite um numero: {i + 1}");
                vetor[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("\n Conteudo do vetor: ");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}