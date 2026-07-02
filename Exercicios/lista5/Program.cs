using System;
using System.Reflection;

namespace lista5
{
    class Program
    {
        static void Main()
        {
          double x, y, z, M;

           // ENTRADA DE DADOS
           Console.WriteLine("Digite o valor de X: ");
           x = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Digite o valor de Y: ");
           y = int.Parse(Console.ReadLine()!); 

           Console.WriteLine("Digite o valor de Z: ");
           z = int.Parse(Console.ReadLine()!);

           //  CALCULOS DA MÉDIA
           M = (x + y + z) / 3;

           // SAIDA DE DADOS
           Console.WriteLine("\n---RESULTADO---");
           Console.WriteLine($"x = {x}");
           Console.WriteLine($"y = {y}");
           Console.WriteLine($"z = {z}");
           Console.WriteLine($"Média = {M}");
        }
    }
}
