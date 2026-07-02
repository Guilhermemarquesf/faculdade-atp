using System;

namespace  atividadeSala2
{
    class Program
    {
        static void Main()
        {
           int prod = 0, pot = 1, fat = 1, x, y;

            Console.WriteLine("Digite X: ");
                 x = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite Y: ");
                 y = int.Parse(Console.ReadLine()!);

            for(int i = 1; i <= y; i++)
            {
                prod += x;
                pot *= x;
                fat *= i;
            }

            Console.WriteLine($"Produto: {prod:F2}");
            Console.WriteLine($"Potência: {pot:F2}");
            Console.WriteLine($"Fatorial: {fat:F2}");
        }
    }
}
