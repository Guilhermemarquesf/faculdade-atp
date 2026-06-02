using System;

namespace matriz10
{
    class Program
    {
        static void Main()
        {
            string[] Nomes = { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo" };
            double[] Notas = { 8.5, 6.0, 9.0, 7.0, 5.5 };

           int i;
           double soma = 0, media;
           int acima = 0, abaixo = 0;
            
            // fazer a soma antes de faer a media 
            for (i = 0; i < Notas.Length; i++)
            {
                soma += Notas[i];
            }
            //atribuir a media geral das notas 
            media = soma / Notas.Length; 
            // exibir o resultado da media geral
            Console.WriteLine($"Media geral : {media:F2}");
            //mostrar o nome e a nota dos alunos com nota acima da media
            Console.WriteLine("\n mostrar o nome e a nota dos alunos com nota acima da média: ");
            // dentro do for vamos fazer uma condiçao, emm que se a nota for maior que a media.Entao ela sera acima, senao abaixo usando if e else.  
            for (i = 0; i < Notas.Length; i++)
            {
                if (Notas[i] > media)
                {
                    Console.WriteLine($"Nome: {Nomes[i]} - Nota: {Notas[i]}");
                    acima++;
                }
                else
                {
                    Console.WriteLine($"Nomes: {Notas[i]} ");
                    abaixo++;
                }
                
           }
            // mostrar resultado das condiçoes 
            Console.WriteLine($"Notas acima {acima}");
            Console.WriteLine($"Notas abaixo {abaixo}");
        }
    }
}

