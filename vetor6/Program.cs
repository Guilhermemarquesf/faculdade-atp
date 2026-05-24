using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[] notas = new double[10];
        double[] frequencias = new double[10];
        string[] situacoes = new string[10];

        // Leitura dos dados
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nAluno {i + 1}");

            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Nota: ");
            notas[i] = double.Parse(Console.ReadLine());

            Console.Write("Frequência: ");
            frequencias[i] = double.Parse(Console.ReadLine());

            // Verifica situação
            if (notas[i] >= 60 && frequencias[i] >= 75)
            {
                situacoes[i] = "Aprovado";
            }
            else
            {
                situacoes[i] = "Reprovado";
            }
        }

        // Mostrar aprovados e posições
        Console.WriteLine("\n=== ALUNOS APROVADOS ===");

        for (int i = 0; i < 10; i++)
        {
            if (situacoes[i] == "Aprovado")
            {
                Console.WriteLine($"Nome: {nomes[i]} - Posição: {i}");
            }
        }

        // Relatório final
        Console.WriteLine("\n=== RELATÓRIO FINAL ===");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nAluno {i + 1}");
            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Nota: {notas[i]}");
            Console.WriteLine($"Frequência: {frequencias[i]}");
            Console.WriteLine($"Situação: {situacoes[i]}");
        }
    }
}