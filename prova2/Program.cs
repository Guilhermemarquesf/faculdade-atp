using System;

namespace imoveis 
{
    class Program
    {
        static void Main()
        {
           
            Console.WriteLine("======================================");
            Console.WriteLine("                 IMÓVEIS              ");
            Console.WriteLine("======================================");

            int n, // quantidade de imoveis 
                cont1 = 0, cont2 = 0, cont3 = 0, // contadores de caixas de cada categoria 
                larg, comp, // dimensoes de cada imovel 
                area, // area de cada imovel
                i; // variavel de controle da repetiçao 
            
            Console.WriteLine("Digite o número de imoveis: ");
            n = int.Parse(Console.ReadLine()!);

            for (i = 1; i <= n; i++)
            {
                Console.Write($"Digite a largura do imovel {i}o.: ");
                larg = int.Parse(Console.ReadLine()!);
                Console.Write($"Digite a largura do imovel {i}o.: ");
                comp = int.Parse(Console.ReadLine()!);

                area = larg * comp;

                if (area <= 100) // categoria C1
                    cont1++;
                else if (area <= 300) // categoria C2
                    cont2++;    
                else 
                    cont3++; // categoria C3

            }

            Console.WriteLine($"Imoveis da categoria C1: {cont1}");
            Console.WriteLine($"Imoveis da categoria C2: {cont2}");
            Console.WriteLine($"Imoveis da categoria C3: {cont3}");
        }
    }
}