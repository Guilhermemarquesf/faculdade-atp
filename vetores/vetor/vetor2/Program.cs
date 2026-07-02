using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters;

int soma = 0;
int[] V = new int[5];

// leitura soma 
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um numero {i + 1}:");
    V[i] = int.Parse(Console.ReadLine()!);

    soma += V[i];
}
Console.WriteLine($"Soma: {soma} ");

// mostrar numeros
Console.WriteLine("Numeros digitados: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(V[i]);
}

Console.WriteLine("Mostrar pares: ");
for (int i = 0; i < 5; i++)
{
    if (V[i] % 2 == 0)
    {
        Console.WriteLine(V[i]);      
    }
}

//menor 
Console.WriteLine("Mostrar Maior: ");
int maior = V[0];

for (int i = 0; i < 5; i++)
{
    if (V[i] > maior)
    {
        maior = V[i];        
    }
}
Console.WriteLine($"Maior: {maior}");

//menor 
Console.WriteLine("Mostrar Menor: ");
int menor = V[0];

for (int i = 0; i < 5; i++)
{
    if (V[i] < menor)
    {
        menor = V[i];
    }
}

Console.WriteLine($"Menor: {menor}");

Console.WriteLine("Mostrar media: ");



