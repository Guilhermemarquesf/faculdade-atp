using System.Security;

int acertos = 0, i, j, n;
int[] aposta, sorteio = new int[6];

Console.WriteLine("Informe o numero de dezenas apostadas: ");
n = int.Parse(Console.ReadLine()!);

aposta = new int [n];

Console.WriteLine("Informe as dezenas apostadas: ");
for (i = 0; i < n; i++)
{
    Console.Write($"Dezena {i+1}: ");
    aposta[i] = int.Parse(Console.ReadLine()!);
}

//verificaçao dos acertos 
for (i = 0; i < aposta.Length; i++)// cada 1 e uma das dezenas apostadas
    for (j = 0; j < sorteio.Length; j++)
        if(aposta[i] == sorteio[i])
            acertos++;            
Console.WriteLine($"Acertos: {acertos}");



