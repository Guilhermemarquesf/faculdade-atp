using System;

namespace funcao13
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

            static int ContaPositivos (int[] w)
            {
                return ContaMaiores (w, 0);
            }                                         
    }
}