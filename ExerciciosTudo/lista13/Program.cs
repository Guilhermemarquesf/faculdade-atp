using System;

namespace lista13
{
    class Program
    {
        static void Main()
        {
           int not1, not2, not3, not4, freq, soma;
           double media;

           Console.WriteLine("Qual a sua frequência na escola? ");
           freq = int.Parse(Console.ReadLine()!); 
           Console.WriteLine("Digite a nota da primeira prova: ");
           not1 = int.Parse(Console.ReadLine()!);
           Console.WriteLine("Digite a nota da segunda prova: ");
           not2 = int.Parse(Console.ReadLine()!);
           Console.WriteLine("Digite a nota da terceira prova: ");
           not3 = int.Parse(Console.ReadLine()!);
           Console.WriteLine("Digite a nota da quarta prova: ");
           not4 = int.Parse(Console.ReadLine()!);

           soma = not1 + not2 + not3 + not4; 
           media = (double)soma / 4;

           if (media >= 60 && freq < 75)
            {
                Console.WriteLine("PARABÉNS! Voceê foi aprovado.");
            }
            else if (media < 60 && freq >= 75)
            {
                Console.WriteLine("Você foi REPROVADO! Estude mais.");
            }
            else if (freq < 75 && media >= 60)
            {
                Console.WriteLine("Você foi REPROVADO! Seja mais frequente.");
            }
            else
            {
                Console.WriteLine("Você foi REPROVADO! Estude mais e seja mais frequente.");
            }
            Console.WriteLine("Frequência: " + freq + "%");
            Console.WriteLine("Média: " + media);
        }
        
    }
}
