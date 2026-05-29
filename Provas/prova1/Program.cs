
using System;

namespace primeiraProva
{
    class Program
    {
        static void Main()
        {
            //1. Escrever para ler a quantidade de numeros a serem lidos.
            Console.WriteLine("Digite a quantidade de números:");
            int n = int.Parse(Console.ReadLine()!);

            int soma = 0;
            int menor = int.MaxValue;
            int pares = 0;

            //2. Escrever um laço de repetição para ler os números.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um número:");
                int numero = int.Parse(Console.ReadLine()!);

                //3. Escrever um código para calcular a soma dos números.
                soma += numero;

                //4. Escrever um código para encontrar o menor número.
                if (numero < menor)
                {
                    menor = numero;
                }

                //5. Escrever um código para contar quantos números são pares.
                if (numero % 2 == 0)
                {
                    pares++;
                }
            }

            //6. Escrever um código para mostrar a soma, o menor número e a quantidade de números pares.
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Quantidade de números pares: " + pares);
            Console.WriteLine("\n Pressione qualquer tecla para sair... ");
        }
    }
}
