using System;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("    Calculadora em C#");
            Console.WriteLine("================================");

            Console.WriteLine("\nEscolha a operação:");
            Console.WriteLine("+ : Soma");
            Console.WriteLine("- : Subtração");
            Console.WriteLine("* : Multiplicação");
            Console.WriteLine("/ : Divisão");
            Console.Write("\nOperação: ");
            string operacao = Console.ReadLine();

            Console.Write("Digite o primeiro valor: ");
            if (!double.TryParse(Console.ReadLine(), out double valor1))
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            Console.Write("Digite o segundo valor: ");
            if (!double.TryParse(Console.ReadLine(), out double valor2))
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            double resultado = 0;
            bool operacaoValida = true;

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine($"\nResultado: {valor1} {operacao} {valor2} = {resultado}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}


