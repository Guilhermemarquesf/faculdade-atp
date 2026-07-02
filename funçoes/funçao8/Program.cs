using System;
using System.ComponentModel;

namespace 
{
    class Program
    {
        static void Main()
        {
           
        }          

        static int ContaPares (int[] V)
        {
            int cont = 0;

            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 == 0)
                {
                    cont++;
                }
            }

            return cont;
        }                          
    }
}