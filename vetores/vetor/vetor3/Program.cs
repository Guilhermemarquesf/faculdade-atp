

int [] V = new int [5];
int soma  = 0, cont = 0, contImpar = 0, x;
double media;
bool achou = false;

// leitura + soma
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite um numero {i + 1}: ");
    V[i] = int.Parse(Console.ReadLine()!);

    soma += V[i];
}

// media
media = (double)soma / 5;
Console.WriteLine($"Media: {media}");

Console.WriteLine("Mostrar pares: ");
for (int i = 0; i < 5 ; i++)
{
    if (V[i] % 2 == 0)
    {
        Console.WriteLine(V[i]);
        cont++;
    }
}
Console.WriteLine($"Quantidade de pares: {cont}");

// ímpares
Console.WriteLine("Mostrar ímpares: ");
for (int i = 0; i < 5; i++)
{
    if (V[i] % 2 != 0)
    {
        Console.WriteLine(V[i]);
        contImpar++;
    }    
}
Console.WriteLine($"Quantidade de ímpares: {contImpar}");

Console.WriteLine("Mostrar ao contrário: ");
for (int i = V.Length - 1; i >= 0; i++)
{
    Console.WriteLine(V[i]);
}

Console.Write("Digite um numero para buscar: ");
x = int.Parse(Console.ReadLine()!);
for (int i = 0; i < V.Length; i++)
{
    if (V[i] == x)
    {
        achou = true;
        break; //para o loop
    }
}

if (achou)
{
    Console.WriteLine("Número encontrado! ");
}
else
{
    Console.WriteLine("Número Não encontrado!");
}














