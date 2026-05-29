using System;

namespace lista19
{
    class Program
    {
        static void Main()
        {
           int n;

           Console.WriteLine("Digite um numero: ");
           n = int.Parse(Console.ReadLine()!);

           for (int i = 1; i >= n; i++)
            {
                Console.WriteLine((2 * i) + " ");
            }

            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine()!);

           for (int i = 1; i >= n; i++)
            {
                Console.WriteLine((2 * i - 1) + " ");
            }
        }
    }
}
