using System;

namespace trabalho2
{
    class Program
    {
        static void Main()
        {
            int n;

            // Validar número de eleitores
            do
            {
                Console.WriteLine("Digite o número de eleitores (mínimo 10): ");
                n = int.Parse(Console.ReadLine()!);

            } while (n < 10);

            while (true) // Repete em caso de empate
            {
                // Ler número dos candidatos
                Console.WriteLine("Digite o número do candidato Teobaldo: ");
                int teobaldo = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite o número do candidato Astrogildo: ");
                int astrogildo = int.Parse(Console.ReadLine()!);

                // Contadores
                int votosTeobaldo = 0;
                int votosAstrogildo = 0;
                int votosBrancos = 0;
                int votosNulos = 0;

                // Coleta dos votos
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Voto do eleitor {i}: ");
                    int voto = int.Parse(Console.ReadLine()!);

                    if (voto == 0)
                    {
                        votosBrancos++;
                    }
                    else if (voto == teobaldo)
                    {
                        votosTeobaldo++;
                    }
                    else if (voto == astrogildo)
                    {
                        votosAstrogildo++;
                    }
                    else
                    {
                        votosNulos++;
                    }
                }

                // Mostrar resultados
                Console.WriteLine("\nRESULTADO DA ELEIÇÃO");
                Console.WriteLine($"Teobaldo: {votosTeobaldo} votos");
                Console.WriteLine($"Astrogildo: {votosAstrogildo} votos");
                Console.WriteLine($"Brancos: {votosBrancos}");
                Console.WriteLine($"Nulos: {votosNulos}");

                // Verificar empate
                if (votosTeobaldo == votosAstrogildo)
                {
                    Console.WriteLine("\nEmpate! Nova eleição será realizada.\n");
                }
                else
                {
                    if (votosTeobaldo > votosAstrogildo)
                    {
                        Console.WriteLine("\nTeobaldo venceu!");
                    }
                    else
                    {
                        Console.WriteLine("\nAstrogildo venceu!");
                    }

                    break; // Sai do loop se não houver empate
                }
            }
        }
    }
}