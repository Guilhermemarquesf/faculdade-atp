int[,] matriz;
int m, n, cont = 1, i, j, soma;

Console.Write("Informe o numero de linhas: ");
m = int.Parse(Console.ReadLine()!);

Console.Write("Informe o numero de colunas: ");
n = int.Parse(Console.ReadLine()!);

matriz = new int[m, n];

// Preenche a matriz
for (i = 0; i < matriz.GetLength(0); i++)
{
    for (j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = cont;
        cont++;
    }
}

// Mostra a matriz e soma das linhas
for (i = 0; i < matriz.GetLength(0); i++)
{
    soma = 0;

    for (j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"{matriz[i, j]} ");
        soma += matriz[i, j];
    }

    Console.WriteLine($"=> {soma}");
}