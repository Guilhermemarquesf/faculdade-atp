using System;

namespace funcao4
{
    class Program
    {
        static int SomaInteiros(int n)
        {
            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                soma += i;
            }

            return soma;
        }

        static int SomaPares(int n)
        {
            return 2 * SomaInteiros(n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SomaInteiros(15));
            Console.WriteLine(SomaPares(15));
        }
    }
}