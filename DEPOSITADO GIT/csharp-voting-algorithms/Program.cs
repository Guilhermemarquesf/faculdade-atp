
using System.ComponentModel;

int idade1, idade2, votos1, votos2;

Console.WriteLine("Quantos anos tem o primeiro candidato ?");
    idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos votos teve o primeiro candidato ?");
    votos1 = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos anos tem o segundo candidato ?");
    idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos votos teve o segundo candidato ?");
    votos2 = int.Parse(Console.ReadLine());

if (votos1 > votos2)
{
   Console.WriteLine("Primeiro candidato venceu"); 
}
else if (votos2 > votos1)
{
    Console.WriteLine("Segundo candidato venceu");
}
else if (idade1 > idade2)
{
    Console.WriteLine("Primeiro candidato venceu");
}
else if (idade2 > idade1)
{
    Console.WriteLine("Segundo candidato venceu");
}
else
{
    Console.WriteLine("Uma nova eleição sera iniciada");
}