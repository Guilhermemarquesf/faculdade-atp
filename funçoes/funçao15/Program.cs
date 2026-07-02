using System;
using System.Runtime.InteropServices;

namespace funcao15
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
    }
}