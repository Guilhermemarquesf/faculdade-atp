using System;

namespace funcao11
{
    class Program
    {
        static void Main()
        {
           int[] V = {3, 8, 5, 10, 11, 12, 15, 21, 20};

           ExibePrimeirosPares(V, 3);
        }     

        static void  ExibePrimeirosPares(int[] V, int n )
        {

            int cont = 0;

            for (int i = 0; i < V.Length; i++)
            {
                if (V[i] % 2 == 0)
                {
                    Console.WriteLine(V[i]);
                    cont++;
                }   

                if (cont == n)
                {
                    break;
                }
            }
        }                                        
    }
}