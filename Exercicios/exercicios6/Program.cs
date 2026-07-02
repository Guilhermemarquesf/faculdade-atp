using System;

namespace numerosInteiros
{
    class Program
    {
        static void Main()
        {
            int numero = 0;
            int pares = 0;
            int impares = 0; 

           Console.WriteLine("Digite a quantidade de números :");
           int n = int.Parse(Console.ReadLine()!);

           for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite o {i} número :");
                numero = int.Parse(Console.ReadLine()!);

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Pares");
                    pares++;
                }
                else
                {
                    Console.WriteLine("Ímpar");
                    impares++;
                }
            }
            Console.WriteLine($"Quantidade de numeros pares:{pares}");
            Console.WriteLine($"Quantidade de numeros impares:{impares}");
        }     
    }
}

