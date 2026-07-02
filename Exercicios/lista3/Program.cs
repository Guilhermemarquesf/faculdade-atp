using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace lista3
{
    class Program
    {
        static void Main()
        {
           int num1, num2;
           int subtração, multiplicação, soma;
           double divisão;

           Console.WriteLine("Digite o primeiro numero: ");
           num1 = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Digite o segundo numero: ");
           num2 = int.Parse(Console.ReadLine()!);

           Console.WriteLine("---Operações:---");

           // Cálculos 
           soma = num1 + num2;
           subtração = num1 - num2;
           divisão = (double) num1 / num2;
           multiplicação = num1 * num2;

           // Saída 
           Console.WriteLine($"\n---Resultados:---");
           Console.WriteLine($"Números: {num1} e {num2}");
           Console.WriteLine($"soma: {soma}");
           Console.WriteLine($"Subtração: {subtração}");
           Console.WriteLine($"divisão: {divisão}");
           Console.WriteLine($"Multiplicação: {multiplicação}");    
        }
    }
}
