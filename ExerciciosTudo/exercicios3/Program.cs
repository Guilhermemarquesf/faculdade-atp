using System;

namespace lgoritmosPUC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("      CAIXA ELETRÔNICO:     ");
            Console.WriteLine("----------------------------");

            //ler o saldo atual
            Console.Write("Digite o saldo atual da conta corrente: ");
                double saldo = Double.Parse(Console.ReadLine()!);

            //mostrar menu de opções
            Console.WriteLine("Escolha a operação desejada:");    
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Pagamento de conta");
            Console.WriteLine("4 - Transferência");

            //ler a opção escolhida
            int opcao = int.Parse(Console.ReadLine()!);

            //ler o valor da operação
            Console.WriteLine("Digite o valor da operação: ");
            double valor = Double.Parse(Console.ReadLine()!);

            //saldo final
            double saldoFinal = saldo;

            //realizar a operação escolhida
            switch (opcao)
            {
                case 1: 
                    saldoFinal = saldo -= valor;
                    break;
                case 2:
                    saldoFinal = saldo += valor;
                    break;
                case 3: 
                    saldoFinal = saldo -= valor;
                    break;
                case 4:
                    saldoFinal = saldo -= valor;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;                          
            }

            //mostrar o saldo final
            Console.WriteLine($"O saldo final da conta é: {saldoFinal}");
        }
    }
}
