using System;

namespace lista18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Todos os números:");
            AllNumbers();

            Console.WriteLine("\nNúmeros pares:");
            NumerosPares();

            Console.WriteLine("\nMúltiplos de 3:");
            MultiplosDeTres();

            Console.WriteLine("\nMúltiplos de 3 pares:");
            MultiplosDeTresPares();

            Console.WriteLine("\nNúmeros até 100 decrescente");
            InteirosDecrescente();
            
            Console.WriteLine("\nQuadrados de 1 a 20:");
            QuadradosDe1a20();
        }

        static void AllNumbers()
        {
            bool primeiro = true;

            for (int i = 0; i <= 50; i++)
            {
                if (!primeiro)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i);
                    primeiro = false;
            }
        }

        static void NumerosPares()
        {
            bool primeiro = true;

            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    if (!primeiro)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i);
                    primeiro = false;
                }
            }
        }

        static void MultiplosDeTres()
        {
            bool primeiro = true;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    if (!primeiro)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i);
                    primeiro = false;
                }
            }
        }

        static void MultiplosDeTresPares()
        {
            bool primeiro = true;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 2 == 0)
                    {
                        if (!primeiro)
                        {
                            Console.Write(", ");
                        }

                        Console.Write(i);
                        primeiro = false;
                    }
                }
            }
        }

        static void InteirosDecrescente()
        {
            bool primeiro = true;
            int[] arrayInteiro = new int[100];

            for (int i = 0; i < 100; i++)
            {
                arrayInteiro[i] = i + 1;
            }

            Array.Reverse(arrayInteiro);
            foreach (int numero in arrayInteiro)
            {
                if (!primeiro)
                {
                    Console.Write(", ");
                }

                Console.Write(numero);
                primeiro = false;
            }
        }

        static void QuadradosDe1a20()
        {
            bool primeiro = true;

            for (int i = 1; i <= 20; i++)
            {
                if (!primeiro)
                {
                    Console.Write(", ");
                }

                Console.Write(i * i);
                primeiro = false;
            }
        }
    }
}