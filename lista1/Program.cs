using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Atividade1();
        Atividade2();
    }

     static void Atividade1()
    {
        string nome;
        DateTime dataN;
        int idade;

        Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine()!;

        Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa):");
            dataN = DateTime.Parse(Console.ReadLine()!);

        idade = DateTime.Now.Year - dataN.Year;

        Console.WriteLine("\n--- Seus Dados ---");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Data: {dataN:dd/MM/yyyy}");
        Console.WriteLine($"Idade: {idade}");
    }
}