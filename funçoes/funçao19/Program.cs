using System;
using System.Reflection;

namespace funcao19
{
    class Program
    {
        static void Main()
        {
           
        }         

        static int MaiorElemento (int[] V)
        {
            int maior = V[0];

            for (int i = 1; i < V.Length; i++)
            {
                if (V[i] > maior)
                {
                    maior = V[i];
                }   
            }

            return (maior);
        }                               
    }
}