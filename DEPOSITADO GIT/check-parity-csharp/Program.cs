using System;

class Program
{
    static void Main()
    {
       Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine(" Esse numeor é par");
        }

        else

        {   
            Console.WriteLine("Esse numeor é impar");
        }
    }
}