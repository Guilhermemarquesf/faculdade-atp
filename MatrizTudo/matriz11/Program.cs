 // Variáveis de controle dos laços e valor informado pelo usuário
int i, j, x;

// le um valor inteiro X
Console.WriteLine("digite um valor inteiro x: ");//pede um valor para o usuario
x = int.Parse(Console.ReadLine()!);// armazena e le o valor

bool[] V = new bool[M.GetLength(1)];// cria um vetor booleano com o numero de colunas da matriz

for (j = 0; j < M.GetLength(1); j++)// percorre todas as colunas das matriz
{
    V[j] = true;// Assume inicialmente que todos os elementos da coluna são maiores que x

    for (i = 0; i < M.GetLength(0); i++)// Percorre todas as linhas da coluna atual
    {
        if (M[i, j] <= x))// Verifica se existe algum elemento menor ou igual a x
        {
            V[j] = false;// Se encontrar, a coluna não atende à condição
            break; // Sai do laço porque não precisa verificar o restante da coluna
        }
    }
}

for (j = 0; j < V.Length; j++)// Percorre o vetor de resultados
{
    Console.WriteLine($"Coluna {j}: {V[j]} "); // Exibe o resultado de cada coluna
}
