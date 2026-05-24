using System;
using System.Diagnostics.Contracts;

namespace OperacoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Bem-vindo à calculadora de operações matemáticas!");
            Console.WriteLine("-------------------------------------------------");

            
            // Exemplo de entrada de dados
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o segundo valor:");
            double valor2 = double.Parse(Console.ReadLine()!);

            //mostrar menu de opções
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - potencia");

            //ler a operação escolhida
            int operacao = int.Parse(Console.ReadLine()!);


            //mostrar o resultado da operação escolhida
            double resultado;

            //usar switch para escolher a operação
            switch (operacao)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    if (valor2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        return;
                    } 
                    resultado = valor1 / valor2;
                    break;
                case 4:
                    resultado = valor1 * valor2;
                    break;
                case 5:
                    resultado = Math.Pow(valor1, valor2);
                    break;   
                default:
                    Console.WriteLine("Operação inválida.");
                    return;
            }

            //mostrar o resultado
                Console.WriteLine($"O resultado da operação é: {resultado}");


        }
    }
}
