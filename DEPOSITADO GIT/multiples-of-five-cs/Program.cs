using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

        if (numero % 5 == 0)
        {
            Console.WriteLine("Ele é múltiplo de 5");    
        }
        else
        {
            Console.WriteLine("O numero " + numero + " é multiplo de 5!");
        }
    }
}