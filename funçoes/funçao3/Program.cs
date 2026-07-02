using System;

namespace funçao3
{
    class Program
    {
        static void MostraNaoPrimos(int x)
        {
           int i;
           for (i = x; i <= x * x; i++)
            {
                if (Divisores(i) > 2)
                {
                    Console.WriteLine(i);
                }
            }
        }                                             
    }
}