using System;

namespace vetor
{
    class Program
    {
        static void Main()
        {
           int n, i, soma = 0, numero, cont1 = 0, cont2 = 0, x;
double media;
int[] V;

Console.WriteLine("Informe a quantidade de numeros: ");
n = int.Parse(Console.ReadLine()!);

V = new int[n];

for (i = 0; i < n; i++)
{
    Console.WriteLine($"Informe o numero {i + 1}/{n}: ");
    numero = int.Parse(Console.ReadLine()!);

    V[i] = numero;
    soma += numero;
}

media = (double)soma / n;

Console.WriteLine($"Media: {media}");

for (i = 0; i < n; i++)
{
    if (V[i] > media)
    {
        Console.WriteLine(V[i]);
        cont1++;
    }
}

Console.WriteLine($"Quantidade de numeros maiores que a media: {cont1}");

Console.Write("Informe o numero procurado: ");
x = int.Parse(Console.ReadLine()!);

for (i = 0; i < n; i++)
{
    if (V[i] == x)
    {
        cont2++;
    }
}

Console.WriteLine($"Quantidade de numeros iguais a {x}: {cont2}");
        }
    }
}

