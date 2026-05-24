using System;

namespace lista12
{
    class Program
    {
        static void Main()
        {
           int idade1, idade2, votos1, votos2;

            Console.WriteLine("Idade do primeiro candidato:");
            idade1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Número de votos do primeiro candidato:");
            votos1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Idade do segundo candidato:");
            idade2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Número de votos do segundo candidato:");
            votos2 = int.Parse(Console.ReadLine()!);

            if (votos1 > votos2)
            {
                Console.WriteLine("O primeiro candidato venceu");
            }
            else if (votos2 > votos1)
            {
                Console.WriteLine("O segundo candidato venceu");
            }
            else // empate nos votos
            {
                if (idade1 > idade2)
                {
                    Console.WriteLine("Empate nos votos, o primeiro candidato venceu por ser mais velho");
                }
                else if (idade2 > idade1)
                {
                    Console.WriteLine("Empate nos votos, o segundo candidato venceu por ser mais velho");
                }
                else
                {
                    Console.WriteLine("Empate total, uma nova eleição deve ser realizada");
                }
                Console.ReadKey();
            }
        }
    }
}
