using System;

namespace funcao10
{
    class Program
    {
        static void Main()
        {
           
        }    

        static int MenorElemento (int[] V)
        {
            int menor = V[0];

            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] < menor)
                {
                    menor = V[i];
                }
            }

            return menor;
        }


    }

}