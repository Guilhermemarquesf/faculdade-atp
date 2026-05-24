using System;

namespace futebol
{
    class Program
    {
        static void Main()
        {
           int jogos, pontos = 0;
           string resultado;

           Console.WriteLine("Digite a quantidade de jogos: ");
           jogos = int.Parse(Console.ReadLine()!);

           for (int i = 1; i <=jogos; i++ )
            {
                Console.WriteLine($"Jogo {i}: Digite V (vitória), E (empate) ou D (derrota)");
                resultado = Console.ReadLine()!;

                switch (resultado)
                {
                    case "V":
                        pontos += 3;
                        break;

                    case "E":
                        pontos += 1;
                        break;

                    case "D":
                        break;

                    default:
                        Console.WriteLine("Entrada inválida! tente novamente ");
                        i++; // repete o mesmoo jogo
                        break;                 
                }
            }   
            Console.WriteLine($"\n total de pontos: {pontos}");

            int maximo = jogos * 3;
            double aproveitamento = (double)pontos / maximo * 100;

            Console.WriteLine($"Aproveitamento: {aproveitamento:F2}%");

            if (aproveitamento <= 50)
            {
                Console.WriteLine("nota baixa");
            }
            else if (aproveitamento <= 75)
            {
                Console.WriteLine("nota boa");
            }
            else
            {
                Console.WriteLine("Pontuação ótima");
            }
        }
    }
}
