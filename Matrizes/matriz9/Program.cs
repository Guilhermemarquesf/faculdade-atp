using System;

namespace matriz9
{
    class Program
    {
        static void Main()
        {
           int i, j, k;

           int[,] M = new int[3, 3];

            Console.WriteLine("Digite o indice da coluna k: ");
            k = int.Parse(Console.ReadLine()!);

            int[] V = new int[M.GetLength(0)];

            for (i = 0; i < M.GetLength(0); i++)
            {
                int soma = 0;

                for (j = 0; j <= k; j++)
                    {
                        soma += M[i, j];
                    }

                V[i] = soma;
            }

            Console.WriteLine("Vetor gerado:");

            for (i = 0; i < V.Length; i++)
            {
                Console.WriteLine($"V[{i}] = {V[i]}");
            }
        }
    }
}

