using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.WriteLine(" Digite um numero:");
            numero = int.Parse(Console.ReadLine());


        if (numero > 0)
        {
            Console.WriteLine("Este número é positivo");
        }    
        else if (numero < 0)
        {
            Console.WriteLine("este número é negativo");
        }
        else
        {
            Console.WriteLine("Este número é igual a zero");
        }
    }
    
}
