using System;

namespace matriz6
{
    class Program
    {
        static void Main()
        {
           int n, i, x;
           int contador = 0;

           Console.WriteLine("Digite um numero:");
           n = int.Parse(Console.ReadLine()!);

           int[] vetor = new int[n];

           for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite um numero: {i + 1}");
                vetor[i] = int.Parse(Console.ReadLine()!);
            }

            Console.Write("\nDigite o número que deseja procurar: ");
            x = int.Parse(Console.ReadLine()!);

            for (i = 0; i < n; i++)
            {
                if (vetor[i] == x)
                {
                    contador++;
                }
            }

            Console.WriteLine($"\nO número {x} aparece {contador} vez(es) no vetor.");
        }
    }
}
