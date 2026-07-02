using System;

namespace funcao20
{
    class Program
    {
        static void Main()
        {
           
        }         

        static int MenorElemento (int[] V)
        {
            int menor = V[0];

            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] < menor)
                {
                    menor = V[0];
                }
            }

            return (menor);
        }                                    
    }
}