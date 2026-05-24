using System;

namespace numeorsparesimpares
{
    class Program
    {
        static void Main()
        {
            int pares = 0;
            int impares = 0;
            int num;

            while (pares < 5 && impares < 5)
            {
                Console.Write("Digite um número inteiro: ");
                num = int.Parse(Console.ReadLine()!);

                if (num % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                Console.WriteLine($"Pares: {pares}");
                Console.WriteLine($"Ímpares: {impares}");
            }

            Console.WriteLine("Programa finalizado!");
        }
    }
}