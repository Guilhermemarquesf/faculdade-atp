using System;

namespace trabalho2
{
    class Program
    {
        static void Main()
        {
           int n;
            // validar número de eleitores
           do
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine()!);
            }while (n < 10);

            while (true) // repetir eleição em caso de empate
            {
                // ler numero de candidatos
                Console.WriteLine("Digite o numero do candidato Teobaldo: ");
                int teobaldo = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite o numero do candidato Astrogildo: ");
                int Astrogildo = int.Parse(Console.ReadLine()!);

                // INICIALIZAÇÃO DOS CONTADORES

                int votosTeobaldo = 0;
                int votosAstrogildo = 0;
                int votosBrancos = 0;
                int votosNulos = 0;

                // COLETA DOS VOTOS

                for (int i = 1; i <= n; i++)
                {
                    //ler votos 
                    Console.WriteLine($"Voto do eleitor{i}: ");
                    int votos = int.Parse(Console.ReadLine()!);

                    if (votos == 0)
                    {   // Voto em branco
                       votosBrancos++;
                    }
                    else if (votos == votosTeobaldo)
                    {
                        votosTeobaldo++;
                    }
                    else if (votos == votosAstrogildo)
                    {
                        votosAstrogildo++;
                    }
                    else
                    {   // Qualquer outro valor é voto nulo
                        votosNulos++;
                    }

                    //mostrar resultados
                    Console.WriteLine("\n resultados da eleição: ");
                    Console.WriteLine($"Teobaldo {teobaldo} votos: ");
                    Console.WriteLine($"Astrogildo {Astrogildo} votos: ");
                    Console.WriteLine($"Brancos {votosBrancos}");
                    Console.WriteLine($"Nulos {votosNulos}");

                    //verificar empate
                    if ( votosAstrogildo == votosTeobaldo)
                    {
                        Console.WriteLine("\n Empate! Nova eleição será realizada");
                    }
                    else
                    {
                        if (votosAstrogildo > votosTeobaldo)
                        {
                            Console.WriteLine("\n Teobaldo venceu! ");
                        }
                        else 
                        {
                            Console.WriteLine("\n Astrogildo venceu! ");
                        }
                        break; // sai do loop se nao tiver empate
                    }
                }
            }
        }
    }
}
