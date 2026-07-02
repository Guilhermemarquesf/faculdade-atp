using System;

namespace funçao1
{
    class Program
    {

        static bool Valida (int n, int i, int j)
        {
            if ()
            {
                
            }
        }   

        static int Divisores (int numero)
        {
            int cont = 0, i; 

            for (i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    cont++;
                }
            }
            return(cont);
        }

        static int MostrarDivisores (int numero)
        {
            int i; 

            for (i = 1; j <= numero; i++)
            {
                if (numero % i == 0)
                
            }
            return
        }




        static void Main()
        {
           int n, j, i;

           Console.WriteLine("Informe o valor a ser validado: ");
           n = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Informe o limite inferior da faixa: ");
           i = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Informe o limite superior da faixa: ");
           j = int.Parse(Console.ReadLine()!);

           if (Valida(n,i,j))
            {
                Console.WriteLine($"{n} esta entre {i} e {j}");
            }
            else
            {
                Console.WriteLine($"{n} nao esta entre {i} e {j}");
            }
           
        }

        static void Main()
        {
           int n; 

           Console.WriteLine("Informe um numero inteiro: ");
           n = int.Parse(Console.ReadLine()!);

           Console.WriteLine($"{n} tem {Divisores} divisores");
           Console.WriteLine("E sao:");
           MostrarDivisores(n);
        }
    }
}

