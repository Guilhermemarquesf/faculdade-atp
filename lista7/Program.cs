using System;

namespace lista7
{
    class Program
    {
        static void Main()
        {
           double num1, num2;

           Console.WriteLine("Digite o primeiro número: ");
           num1 = double.Parse(Console.ReadLine()!);

           Console.WriteLine("Digite o segundo número: ");
           num2 = double.Parse(Console.ReadLine()!);

           // Ver se eles sao iguais  
           if (num1 == num2)
            {
                Console.WriteLine("\nEles são iguais");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"\nMaior valor: {num1}");
                Console.WriteLine($"Menor valor: {num2}");
            }
            else 
            {
                Console.WriteLine($"\nMaior valor: {num2}");
                Console.WriteLine($"Menor valor: {num1}");                   
            }

        }
    }
}
