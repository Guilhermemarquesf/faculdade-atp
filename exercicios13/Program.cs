using System;

namespace valorSoma
{
    class Program
    {
        static void Main()
        {
           int n, num = 1, den, i;
           double soma = 0;

           Console.WriteLine("Digite um numero: ");
           n = int.Parse(Console.ReadLine());

           den = n;

           for (i = 1; i <= n; i++)
            {
                soma = soma + ((double) num / den );
                num++;
                den--;
            }
            Console.WriteLine($"A soma é: {soma}");



        }
    }
}