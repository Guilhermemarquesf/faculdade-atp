int n, i, j;
string opcao;

Console.WriteLine("Digite o numero de cidades: ");
n = int.Parse(Console.ReadLine()!);

string[] cidades = new string[n];

for (i = 0; i < n; i++)
{
    Console.WriteLine("Digite o nome da cidade: ");
    cidades[i] = Console.ReadLine()!;
}

double[,] temperaturas = new double[n, 8];

do
{
    Console.WriteLine("\nMENU");
    Console.WriteLine("A - Registrar temperatura de uma cidade");
    Console.WriteLine("B - Exibir temperatura de uma cidade");
    Console.WriteLine("C - Exibir temperaturas geral");
    Console.WriteLine("D - Exibir temperatura média de uma cidade");
    Console.WriteLine("E - Exibir temperaturas médias geral");
    Console.WriteLine("F - Sair");

    opcao = Console.ReadLine()!.ToLower();

    switch (opcao)
    {
        case "a":

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(i + " - " + cidades[i]);
            }

            Console.WriteLine("Escolha a cidade:");
            int cidade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite a nova temperatura:");
            double temp = double.Parse(Console.ReadLine()!);

            for (j = 7; j > 0; j--)
            {
                temperaturas[cidade, j] =
                temperaturas[cidade, j - 1];
            }

            temperaturas[cidade, 0] = temp;

            Console.WriteLine("Temperatura registrada!");
            break;

        case "b":

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(i + " - " + cidades[i]);
            }

            Console.WriteLine("Escolha a cidade:");
            cidade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Temperaturas de " + cidades[cidade]);

            for (j = 0; j < 8; j++)
            {
                Console.Write(temperaturas[cidade, j] + " ");
            }

            Console.WriteLine();
            break;

        case "c":

            for (i = 0; i < n; i++)
            {
                Console.Write(cidades[i] + ": ");

                for (j = 0; j < 8; j++)
                {
                    Console.Write(temperaturas[i, j] + " ");
                }

                Console.WriteLine();
            }

            break;

        case "d":

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(i + " - " + cidades[i]);
            }

            Console.WriteLine("Escolha a cidade:");
            cidade = int.Parse(Console.ReadLine()!);

            double soma = 0;

            for (j = 0; j < 8; j++)
            {
                soma += temperaturas[cidade, j];
            }

            double media = soma / 8;

            Console.WriteLine("Média de " + cidades[cidade] + ": " + media);

            break;

        case "e":

            for (i = 0; i < n; i++)
            {
                double somaGeral = 0;

                for (j = 0; j < 8; j++)
                {
                    somaGeral += temperaturas[i, j];
                }

                double mediaGeral = somaGeral / 8;

                Console.WriteLine(cidades[i] + ": " + mediaGeral);
            }

            break;

        case "f":

            Console.WriteLine("Saindo...");
            break;

        default:

            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != "f");