using System;

namespace lista4
{
    class Program
    {
        static void Main()
        {
           double valorCompra, valorPago, troco;

           Console.WriteLine("Digite o valor da compra: ");
           valorCompra = double.Parse(Console.ReadLine()!);

           Console.WriteLine("Digite o valor pago: ");
           valorPago = double.Parse(Console.ReadLine()!);

            troco = valorCompra - valorPago;

            Console.WriteLine($"Valor da compra: {valorCompra}");
            Console.WriteLine($"Valor pago: {valorPago}");
            Console.WriteLine($"Troco: {troco} ");
        }
    }
}