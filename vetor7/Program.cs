using System;
using System.Net.Http.Headers;

namespace vetor7
{
    class Program
    {
        static void Main()
        {
           Console.Write("Quantidade de veículos: ");
           int n = int.Parse(Console.ReadLine()!);

           string[] placa = new string[n];
           double[] multa = new double[n];

           double soma = 0;
           int contador = 0;

           for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a placa: ");
                placa[i] = Console.ReadLine()!;

                Console.WriteLine("Digite a multa: ");
                multa[i] = double.Parse(Console.ReadLine()!);

                if (multa[i] != 0)
                {
                    soma += multa[i];
                    contador++;
                }
            }

            double media = soma / contador;

            Console.WriteLine("\nVeículos com multa acima da média:");

            for (int i = 0; i < n; i++)
            {
                if (multa[i] > media)
                {
                   Console.WriteLine($"Placa: {placa[i]}");
                   Console.WriteLine($"Multa: {multa[i]}");
                }
            }
        }
    }
}
