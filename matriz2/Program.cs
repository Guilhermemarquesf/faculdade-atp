using System;

namespace matriz2
{
    class Program
    {
        static void Main()
        {
            string[] alfabeto = {
                "a","b","c","d","e","f","g","h","i","j","k","l","m",
                "n","o","p","q","r","s","t","u","v","w","x","y","z"
            };

            int[] cont = new int[26];

            int i, j;

            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine()!.ToLower();

            for (i = 0; i < alfabeto.Length; i++)
            {
                for (j = 0; j < palavra.Length; j++)
                {
                    if (alfabeto[i] == palavra[j].ToString())
                    {
                        cont[i]++;
                    }
                }
            }

            for (i = 0; i < cont.Length; i++)
            {
                if (cont[i] > 1)
                {
                    Console.WriteLine($"{alfabeto[i]}: {cont[i]} vezes");
                }
                else if (cont[i] == 1)
                {
                    Console.WriteLine($"{alfabeto[i]}: {cont[i]} vez");
                }
            }
        }
    }
}