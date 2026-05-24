int i, n;
double soma = 0;
double[] V;

Console.WriteLine("Informe o tamanho da sequencia: ");
n = int.Parse(Console.ReadLine()!);

V = new double[n];

for (i = 0; i < V.Length; i++)
{
    V[i] = Math.Sqrt(2*(i+1)) / Math.Pow(i+1, 2);
    soma = soma + V[i];
    Console.WriteLine($"Posiçao {i}: {V[i]}");

}

Console.WriteLine($"Soma: {soma}");



