using System;

namespace lista6
{
    class Program
    {
        static void Main()
        {
            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura em Celsius");
            celsius = double.Parse(Console.ReadLine()!);

            fahrenheit = (celsius * 9.0 / 5) + 32;

            Console.WriteLine($"Em Fahrenheit:  {fahrenheit}");

            Console.WriteLine("Digite a temperatura em Fahrenheit");
            fahrenheit = double.Parse(Console.ReadLine()!);

            celsius = (fahrenheit - 32) * 5.0 / 9;

            Console.WriteLine($"Em Celsius: {celsius}");



        }
    }
}
