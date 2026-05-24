using System;

namespace lista19
{
    class Program
    {
        static void Main()
        {
           

           Console.WriteLine("Digite um numero: ");
           int n = int.Parse(Console.ReadLine()!);

           for (int i = 1; i >= n; i++)
            {
                Console.WriteLine((2 * i) + " ");
            }

            Console.WriteLine("Digite um numero: ");
           int n = int.Parse(Console.ReadLine()!);

           for (int i = 1; i >= n; i++)
            {
                Console.WriteLine((2 * i - 1) + " ");
            }
        }
    }
}
