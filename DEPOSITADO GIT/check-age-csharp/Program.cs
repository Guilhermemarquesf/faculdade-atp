using System;

class Program
{
    static void Main()
    {
        int idade;

        Console.WriteLine(" Quantos anos voce tem ? ");
            idade = int.Parse(Console.ReadLine());


        if (idade < 0)
        {
            Console.WriteLine(" Idade inválida. ");
        }
        else if (idade >= 18)
        {
            Console.WriteLine(" Voce já é maior de idade. ");
        }    
        else
        {
            Console.WriteLine("Voce nao é maior de idade");
        }

    }
}