using System;

namespace primos 
{
    class Program
    {
        static void Main()
        {
           int n, div = 0, i;

           Console.WriteLine("Digite um numero: ");
           n = int.Parse(Console.ReadLine()!);

           for (i = 1; i <= n; i++)
           {
                if (n % i == 0)
                    div++;
           }

           if (div > 2)
                Console.WriteLine("Não é primo");
           else 
                Console.WriteLine("É primo");
        }
    }
}