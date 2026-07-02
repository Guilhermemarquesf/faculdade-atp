using System;

namespace funçao2
{
    class Program
    {
        static void Main()
        {
           int SomaSerie (int a, int b, int n)
        {
            int resultado = 0;
            for (int i = 0; i <= n; i++)
            {
                resultado += (a + b * i);
            }
            return(resultado);
        }
        }                                             
    }
}