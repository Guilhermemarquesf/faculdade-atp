using System;

class Program
{
    static void Main()
    {
        int n1, n2, n3, n4;
        int soma;
        double media;
        int maior, menor;
        int positivo = 0, negativo = 0, nulo = 0;
        int par = 0, impar = 0;

        Console.WriteLine("===========================================");
        Console.WriteLine("       Sistema de Processamento Numérico   ");
        Console.WriteLine("===========================================");

        Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o terceiro numero: ");
            n3 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o quarto numero: ");
            n4 = int.Parse(Console.ReadLine()!);

        /*calculo basico */ 
        soma = n1 + n2 + n3 + n4;

        Console.WriteLine("A soma total é: " + soma);

        media = soma / 4.0;
        Console.WriteLine("A média é: " + media);

        /*maior e menor */
        maior = n1;
        menor = n1;

        if(n2 > maior) maior = n2;
        if(n2 < menor) menor = n2;

        if(n3 > maior) maior = n3;
        if(n3 < menor) menor = n3;

        if(n4 > maior) maior = n4;
        if(n4 < menor) menor = n4;

        // Teste Positivo ou negativo
        if (n1 > 0) positivo++;
        else if (n1 < 0) negativo++;
        else nulo++;

        if (n2 > 0) positivo++;
        else if (n2 < 0) negativo++;
        else nulo++;

        if (n3 > 0) positivo++;
        else if (n3 < 0) negativo++;
        else nulo++;

        if (n4 > 0) positivo++;
        else if (n4 < 0) negativo++;
        else nulo++;

        // Teste Par ou Ímpar
        if (n1 % 2 == 0) par++;
        else impar++;

        if (n2 % 2 == 0) par++;
        else impar++;

        if (n3 % 2 == 0) par++;
        else impar++;

        if (n4 % 2 == 0) par++;
        else impar++;

        // mensagem final
        Console.WriteLine("\n--- RESULTADOS FINAIS ---");
        Console.WriteLine($"a) Soma: {soma}");
        Console.WriteLine($"b) Media: {media}");
        Console.WriteLine($"c) Maior: {maior}");
        Console.WriteLine($"d) Menor: {menor}");
        Console.WriteLine($"e) Pares: {par}");
        Console.WriteLine($"f) Impares: {impar}");
        Console.WriteLine($"g) Positivos: {positivo}");
        Console.WriteLine($"h) Negativos: {negativo}");
        Console.WriteLine($"i) Nulo: {nulo}");
        Console.WriteLine("------------------------------");


    }
}



