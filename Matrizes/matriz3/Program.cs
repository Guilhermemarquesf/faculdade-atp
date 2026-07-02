using System;

namespace matriz3
{
    class Program
    {
        static void Main()
        {
           string[] nomes = new string[10];
           double[] notas = new double[10];
           double[] frequencia = new double[10];
           string[] situacao = new string[10]; 

           int i;

           for ( i = 0; i < 10; i++)
            {

                Console.WriteLine($"\nAluno {i + 1}");

                Console.WriteLine("Qual seu nome: ");
                nomes[i] = Console.ReadLine()!;

                Console.WriteLine("Qual sua nota: ");
                notas[i] = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Qual sua frequencia: ");
                frequencia[i] = double.Parse(Console.ReadLine()!);
            }

            for ( i = 0; i < 10; i++)
            {
                if (notas[i] >= 60 && frequencia[i] >= 75)
                {
                    situacao[i] = "Aprovado";
                }
                else
                {
                    situacao[i] = "Reprovado";
                }
            }

            for ( i = 0; i < 10; i++)
            {
                if (situacao[i] == "Aprovado")
                {
                    Console.WriteLine($"Nome: {nomes[i]} - Posição: {i} ");
                }
            }

            Console.WriteLine($"\n Relatório final ");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nAluno {i + 1}");

                Console.WriteLine($"Nome: {nomes[i]}");
                Console.WriteLine($"Nota: {notas[i]}");
                Console.WriteLine($"Frequência: {frequencia[i]}");
                Console.WriteLine($"Situação: {situacao[i]}");
            }
        }
    }
}