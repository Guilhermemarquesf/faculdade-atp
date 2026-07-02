using System;
namespace MediaIdades
{
    class Program
    {
        static void Main()
        {
          int soma = 0;
          for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite a idade da pessoa '" + i + "':"   );
                int idade = int .Parse(Console.ReadLine()!);
                soma += idade;
            }
            Console.WriteLine("A média das idades é: " + (soma / 10));

        }
    }
}
