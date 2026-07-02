using System;

namespace TrabalhoPUC
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("   CONVERSÃO TEMPERATURA  ");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Escolha: (a) Celsius para Fahrenheit ou (b) Fahrenheit para Celsius");
            string opcao = Console.ReadLine().ToLower();

            Console.Write("Digite a temperatura original: ");
            // Usamos double.Parse para aceitar números com vírgula
            double temp = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case "a":
                    resultado = (temp * 1.8) + 32;
                    Console.WriteLine($"Resultado: {resultado:F2}°F");
                    break;

                case "b":
                    resultado = (temp - 32) / 1.8;
                    Console.WriteLine($"Resultado: {resultado:F2}°C");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            // Linha importante para o terminal não fechar sozinho:
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}