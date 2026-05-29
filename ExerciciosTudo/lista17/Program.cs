using System;
using System.Reflection;

namespace lista17
{
    class Program
    {
        static void Main()
        {

           Console.WriteLine("escreva todos os numeros inteiros de 0 a 50: ");

           for (int i = 0; i <= 50; i++)
            {
                if(i < 50)
                Console.Write(i + ",");
                else
                Console.Write(i);
                
            }
            Console.WriteLine();
            Console.WriteLine("Escreva todos os numeros inteiros pares de 0 a 50: ");

            for (int i = 0; i <= 50; i+= 2)
            {
                if (i < 50)
                Console.Write(i + ",");
                else 
                Console.Write(i);             
            }
            Console.WriteLine();
            Console.WriteLine("Escreva todos os numeros inteiros multiplos de 3 de 1 a 50: ");

            for (int i = 3; i <= 50; i += 3)
            {
               if (i < 48)
                    Console.Write(i + ", ");
                    else
                    Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("Escreva todos os numeros inteiros pares e multiplos de 3 de 0 a 50: ");
            
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i < 48)
                    Console.Write(i + ", ");
                    else
                    Console.Write(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Escreva todos os numeros inteiros de 100 a 1 (em ordem decrescente);: ");

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("escreva o quadrado dos numeros inteiros que estao no intervalo fechado de 1 a 20: ");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i * i);
            }


        }
    }
}
