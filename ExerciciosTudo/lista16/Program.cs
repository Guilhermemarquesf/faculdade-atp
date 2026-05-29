using System;

namespace lista16
{
    class Program
    {
        static void Main()
        {
           int idade;

           Console.Write("Digite sua idade: ");
           idade = int.Parse(Console.ReadLine()!);

           if (idade <= 17)
            {
                Console.WriteLine("Menor de idade");
            }
            else if (idade <= 64)
            {
                Console.WriteLine("Maior de idade");
            }
            else 
            {
                Console.WriteLine("Pessoa idosa");
            }

        }
    }
}
