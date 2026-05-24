int qtdEmpregados, VendasB;
double salarioMin, pCusto, pVenda, comissao,
    salarioFin, lucro;


Console.Write("Quantos empregados há na loja? ");
qtdEmpregados = int.Parse(Console.ReadLine());
Console.Write("Qual é o valor do salário mínimo? R$ ");
salarioMin = double.Parse(Console.ReadLine());
Console.Write("Qual é o preço de custo? R$ ");
pCusto = double.Parse(Console.ReadLine());
Console.Write("Quantas bicicletas foram vendidas? ");
VendasB = int.Parse(Console.ReadLine());


pVenda = pCusto * 1.5;
comissao = pCusto * 0.15 * VendasB / qtdEmpregados;
comissao = pCusto * 0.15 * VendasB / qtdEmpregados;

salarioFin = 2 * salarioMin + comissao;

lucro = VendasB * pVenda - pCusto * VendasB - salarioFin * qtdEmpregados;

Console.WriteLine( "O salário final de cada empregado é R$ (salarioFin)");
Console.WriteLine( "O lucro da loja é de R$ (lucro");