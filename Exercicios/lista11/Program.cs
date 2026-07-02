using System;

namespace lista11
{
    class Program
    {
        static void Main()
        {
           int voto1, voto2;
           string cand1, cand2;

           Console.WriteLine("Qual o nome do primeiro candidato: ");
           cand1 = Console.ReadLine()!;

           Console.WriteLine("Número de votos: ");
           voto1 = int.Parse(Console.ReadLine()!);

           Console.WriteLine("Qual o nome do segundo candidato: ");
           cand2 = Console.ReadLine()!;

           Console.WriteLine("Número de votos: ");
           voto2 = int.Parse(Console.ReadLine()!);

           if (voto1 > voto2)
            {
                Console.WriteLine($"O {cand1} candidato venceu");
            }
            else if (voto2 > voto1)
            {
                Console.WriteLine($"O {cand2} candidato venceu");
            }
            else
            {
                Console.WriteLine("Empate! uma nova eleição deve ser realizada ");
            }
              Console.ReadKey();
        }
    }
}
