using System;
using System.Data;

class Program
{
    static void Main()
    {
        int numero;

        Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());

        if (numero >= 0 && numero <= 100)
        {
            Console.WriteLine("Ele está entre 0 e 100");
        }    
        else
        {
            Console.WriteLine("Ele não esta 0 e 100");
        }
    }
}