using System;

namespace lista9
{
    class Program
    {
        static void Main()
        {
           int num1, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine()!);

            if (num1 > num2)
            {
                Console.WriteLine($"O primeiro número é maior: {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"O segundo número é maior: {num2}");
            }
            else
            {
                Console.WriteLine("os números são iguais ");
            }

        Console.WriteLine("\nDigite uma tecla para sair");
        Console.ReadKey();
        }
        
    }
}
