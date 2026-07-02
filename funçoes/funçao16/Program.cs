using System;

namespace funcao16
{
    class Program
    {
        static void Main()
        {
           
        }

        static int ContaMaiores (int[] V, int x)
        {
            int cont = 0;

            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] > x)
                {
                    cont++;
                }
            }

            return (cont);
        }         

        static int ContaPositivos (int[] V)
        {
            return (ContaMaiores(V, 0));
        }                                    
    }
}