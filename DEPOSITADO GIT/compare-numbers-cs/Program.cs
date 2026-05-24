using System;
using System.Data;

class Program
{
    static void Main()
    {
        int numero1, numero2;

        Console.WriteLine("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um numero");
            numero2 = int.Parse(Console.ReadLine());  

        if (numero1 > numero2)
        {
            Console.WriteLine("O primeiro numero é maior ");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("O segundo numero é maior ");
        }          
        else
        {
            Console.WriteLine("Os dois numeros são iguais");
        }
    }
}