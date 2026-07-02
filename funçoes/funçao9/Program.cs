using System;
using System.Reflection.Metadata.Ecma335;

namespace funcao9
{
    class Program
    {
        static void Main()
        {
           int a = 2;
           int b = 3;
           int n = 4;

           int resultado = SomaSeries(a, b, n);

           Console.WriteLine(resultado);
        }       

        static int SomaSeries (int a, int b, int n)
        {
            int soma = 0;
            
            for (int i = 0; i <= n; i++)
            {
                soma += a + i * b;
            }

            return soma;
        }
                                              
    }
}