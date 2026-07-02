using System;

namespace funcao14
{
    class Program
    {
        static void Main()
        {
           
        }   

        static int SomaDiagonal (int[,] M)
        {
            int Soma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Soma += M[i, i];
                    }
                }
            }

            return Soma;
        }                                          
    }
}