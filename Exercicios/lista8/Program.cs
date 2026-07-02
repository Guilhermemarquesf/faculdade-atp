using System;
using System.Globalization;

namespace lista8
{
    class Program
    {
        static void Main()
        {
            int num;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine()!);

            if (num % 2 == 0)
            {
                Console.WriteLine($"\n Número par: {num}");


            }
            else
            {
                Console.WriteLine($"\n Número ímpar: {num}");
            }
            Console.WriteLine("\nDigite uma tecla para sair");
            Console.ReadKey();
        }
    }
}
