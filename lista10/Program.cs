using System;

namespace lista10
{
    class Program
    {
        static void Main()
        {
          int n;

          Console.Write("Digite um número: ");
          n = int.Parse(Console.ReadLine()!);

          if (n > 0)
            {
                Console.Write("--Número positivo--");
            }
          else if (n < 0)
            {
                Console.Write("--Número negativo--");
            }  
            else
            {
                Console.Write("Nulo");
            }

        }
    }
}
