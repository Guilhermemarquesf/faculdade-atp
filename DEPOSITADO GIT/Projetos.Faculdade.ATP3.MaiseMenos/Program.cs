int Numero1, Numero2;

Console.Write("Informe o primeiro numero: ");
Numero1 = int.Parse(Console.ReadLine());  
Console.Write("Informe o segundo numero: ");
Numero2 = int.Parse(Console.ReadLine()); 

if (Numero1 > Numero2)
{
    Console.WriteLine($"maior: {Numero1}");
    Console.WriteLine($"menor: {Numero2}");
}
else
{
    Console.WriteLine($"maior: {Numero2}");
    Console.WriteLine($"menor: {Numero1}");
}
