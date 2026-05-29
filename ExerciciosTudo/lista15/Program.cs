using System;
using System.Globalization;

namespace lista13
{
    class Program
    {
        static void Main()
        {
            int hExtras;
            double salBase, valorHora, totalExtra, salarioTotal;

            Console.WriteLine("Digite seu salário base: ");
            salBase = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a quantidade de horas extras mensais: ");
            hExtras = int.Parse(Console.ReadLine()!);

            if (hExtras <= 10)
            {
                valorHora = salBase * 0.01;
            }
            else if (hExtras <= 20)
            {
                valorHora = salBase * 0.02;
            }
            else
            {
                 valorHora = salBase * 0.03;
            }
            totalExtra = valorHora * hExtras;
            salarioTotal = salBase + totalExtra;           

            Console.WriteLine($"Salário base: {salBase}");
            Console.WriteLine($"Horas extras: {hExtras}");
            Console.WriteLine($"Valor da hora extra: {valorHora}");
            Console.WriteLine($"Total de horas extras: {totalExtra}");
            Console.WriteLine($"Salário total: {salarioTotal}");
        }
        
    }
}


