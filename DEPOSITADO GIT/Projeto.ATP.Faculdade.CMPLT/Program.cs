using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor total da compra: ");
            double valorCompra = double.Parse(Console.ReadLine());

        Console.WriteLine("Forma de pagamento: ");
            string formaPagamento = Console.ReadLine().ToUpper();

        Console.WriteLine("Qual o tipo de cliente (N para Normal, F para Fidelidade)? ");
            string tipoCliente = Console.ReadLine().ToUpper();  

        double percentualDesconto = 0; // Começamos com zero

        if (formaPagamento == "D")
        {
            if (valorCompra <= 100)
            {
                percentualDesconto = 5; // Desconto referente a compra de R$100
            }
            else
            {
                percentualDesconto = 10; // Acima de 100
            }
        }    
        else if (formaPagamento == "C")
        {
            if (valorCompra <= 100) // Até R$100
            {
                percentualDesconto = 0; // Ele não terá desconto
            }
            else if (valorCompra <= 300) // Maior do que 100
            {
                percentualDesconto = 5; // Desconto de 5%
            }
            else
            {
                percentualDesconto = 10;
            }
        }  

        // Regra 1: Cliente Fidelidade com compra alta 
        if (tipoCliente == "F" && valorCompra > 200)
        {
            percentualDesconto = percentualDesconto + 5; // Ganha mais 5%
        }

        // Regra 2: Cliente Fidelidade pagando em dinheiro 
        if (tipoCliente == "F" && formaPagamento == "D")
        {
             percentualDesconto = percentualDesconto + 2; // Ele ganha 2% extras
        }

        // Limite máximo de 15%
        if(percentualDesconto > 15)
        {
            percentualDesconto = 15;
        }

        double valorDescontoReais = (valorCompra * percentualDesconto) / 100;
        double valorFinal = valorCompra - valorDescontoReais;

        Console.WriteLine("--- RESUMO DA COMPRA ---");
        Console.WriteLine($"Valor Original: {valorCompra:C2}");
        Console.WriteLine($"Desconto Aplicado: {percentualDesconto}%");
        Console.WriteLine($"Valor do Desconto: {valorDescontoReais:C2}");
        Console.WriteLine($"Total a Pagar: {valorFinal:C2}");

        //... (todos os codigos de calculo e Console.WriteLine anteriores)

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
