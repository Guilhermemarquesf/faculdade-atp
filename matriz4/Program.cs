using System;

namespace matriz4
{
    class Program
    {
        static void Main()
        {
           int soma = 0, n, i; 
           double acimaMedia = 0;

           Console.WriteLine($"Digite um numero:");
           n = int.Parse(Console.ReadLine()!);

           int[] vetor = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite um numero {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine()!);

                soma += vetor[i];
            }

            double media = (double)soma / n;

            for (i = 0; i < n; i++)
            {
                if (vetor[i] > media)
                {
                    acimaMedia++;
                }
            }

             Console.WriteLine($"\n resultados finais: ");
                Console.WriteLine($"Soma {soma}");
                Console.WriteLine($"Media {media}");
                Console.WriteLine($"Quantidade acima da Media {acimaMedia}");
        }
    }
}
