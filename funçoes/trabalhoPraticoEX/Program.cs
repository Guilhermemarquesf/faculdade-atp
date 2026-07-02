// CÓDIGO GUILHERME

﻿using System;
using System.IO;

class Program
{
    // Arquivo de entrada e arquivo onde será gravado o resultado da eleição
    static StreamReader arqEntrada = new StreamReader("eleicao_in.txt");
    static StreamWriter arqSaida = new StreamWriter("eleicao_out.txt");

    static void Main()
    {
        // Lê a quantidade de candidatos
        int n = LerQuantidadeCandidatos();

        // Vetores para armazenar o número e o nome de cada candidato
        int[] numero = new int[n];
        string[] nome = new string[n];

        // Lê os dados dos candidatos
        LerCandidatos(n, numero, nome);

        // Lê a quantidade de eleitores
        int m = LerQuantidadeEleitores();

        // Vetores para armazenar as informações dos eleitores
        string[] titulo = new string[m];
        string[] nomeEleitor = new string[m];
        string[] nascimento = new string[m];
        int[] idade = new int[m];
        int[] voto = new int[m];

        // Lê todos os dados dos eleitores
        LerEleitores(m, titulo, nomeEleitor, nascimento, idade, voto);

        // Faz a contagem dos votos e mostra o resultado
        ApurarEleicao(numero, nome, voto);

        // Fecha os arquivos utilizados
        arqEntrada.Close();
        arqSaida.Close();
    }

    // Métodos responsáveis pela escrita na tela e no arquivo

    // Escreve uma mensagem no console
    static void EscreverTela(string texto)
    {
        Console.WriteLine(texto);
    }

    // Escreve uma mensagem no arquivo de saída
    static void EscreverArquivo(string texto)
    {
        arqSaida.WriteLine(texto);
    }

    // Métodos responsáveis pela leitura dos dados

    // Lê a quantidade de candidatos. 
    // Caso seja menor que 3, continua lendo até encontrar um valor válido.
    static int LerQuantidadeCandidatos()
    {
        int n = int.Parse(arqEntrada.ReadLine()!);

        while (n < 3)
        {
            n = int.Parse(arqEntrada.ReadLine()!);
        }

        return n;
    }

    // Lê o número e o nome de cada candidato
    static void LerCandidatos(int n, int[] numero, string[] nome)
    {
        for (int i = 0; i < n; i++)
        {
            numero[i] = int.Parse(arqEntrada.ReadLine()!);
            nome[i] = arqEntrada.ReadLine()!;
        }
    }

    // Lê a quantidade de eleitores.
    // Caso seja menor que 10, continua lendo até encontrar um valor válido.
    static int LerQuantidadeEleitores()
    {
        int m = int.Parse(arqEntrada.ReadLine()!);

        while (m < 10)
        {
            m = int.Parse(arqEntrada.ReadLine()!);
        }

        return m;
    }

    // Lê todas as informações dos eleitores
    static void LerEleitores(
        int m,
        string[] titulo,
        string[] nome,
        string[] nascimento,
        int[] idade,
        int[] voto)
    {
        for (int i = 0; i < m; i++)
        {
            titulo[i] = arqEntrada.ReadLine()!;
            nome[i] = arqEntrada.ReadLine()!;
            nascimento[i] = arqEntrada.ReadLine()!;
            idade[i] = int.Parse(arqEntrada.ReadLine()!);
            voto[i] = int.Parse(arqEntrada.ReadLine()!);
        }
    }

    // Método responsável pela apuração dos votos

    static void ApurarEleicao(int[] numero, string[] nome, int[] voto)
    {
        // Vetor que armazenará a quantidade de votos de cada candidato
        int[] votosCandidato = new int[numero.Length];

        // Contadores de votos brancos e nulos
        int branco = 0;
        int nulo = 0;

        // Percorre todos os votos registrados
        for (int i = 0; i < voto.Length; i++)
        {
            // Voto igual a zero é considerado branco
            if (voto[i] == 0)
            {
                branco++;
            }
            else
            {
                // Variável para verificar se o voto pertence a algum candidato
                bool encontrou = false;

                // Procura o número do candidato
                for (int j = 0; j < numero.Length; j++)
                {
                    if (voto[i] == numero[j])
                    {
                        votosCandidato[j]++;
                        encontrou = true;
                        break;
                    }
                }

                // Caso o número não exista, o voto é nulo
                if (!encontrou)
                {
                    nulo++;
                }
            }
        }

        // Exibe o resultado final da eleição
        MostrarResultado(nome, numero, votosCandidato, branco, nulo);
    }

    // Método responsável por mostrar o resultado da eleição

    static void MostrarResultado(
        string[] nome,
        int[] numero,
        int[] votos,
        int branco,
        int nulo)
    {
        // Escreve o título do relatório
        EscreverTela("RESULTADO DA ELEIÇÃO");
        EscreverArquivo("RESULTADO DA ELEIÇÃO");

        // Mostra a quantidade de votos de cada candidato
        for (int i = 0; i < nome.Length; i++)
        {
            string linha = numero[i] + " - " + nome[i] + ": " + votos[i] + " votos";

            EscreverTela(linha);
            EscreverArquivo(linha);
        }

        // Mostra a quantidade de votos brancos e nulos
        EscreverTela("Brancos: " + branco);
        EscreverTela("Nulos: " + nulo);

        EscreverArquivo("Brancos: " + branco);
        EscreverArquivo("Nulos: " + nulo);
    }
}

// CÓDIGO MATHEUS
using System.IO;
using System;
using System.Linq;

public class Program {
    static StreamReader arqEntrada = new StreamReader("eleicao_in.txt");
    static StreamWriter arqSaida = new StreamWriter("eleicao_out.txt");
    public static void Eleicao() {
      string linha = "";
      int linha_num = 0;
      while (linha_num <= 3 && !arqEntrada.EndOfStream) {
          linha = arqEntrada.ReadLine();
          linha_num = int.Parse(linha);
      }
      int n = linha_num;
      string[] candidatos_numero = new string[n];
      string[] candidatos_nome = new string[n];
      for (int i = 0; i < n; i++) {
        candidatos_numero[i] = arqEntrada.ReadLine();
        candidatos_nome[i] = arqEntrada.ReadLine();
      }
      while (linha_num <= 10 && !arqEntrada.EndOfStream) {
        linha = arqEntrada.ReadLine();
        linha_num = int.Parse(linha);
      }
      int m = linha_num;
      string[] numero_titulo_eleitoral = new string[m];
      string[] eleitores_nome = new string[m];
      string[] eleitores_nascimento = new string[m];
      string[] eleitores_idade = new string[m];
      int[] numero_de_votos_candidatos = new int[n];
      int votos_brancos = 0;
      int votos_nulos = 0;
      for (int i = 0; i < m; i++) {
        numero_titulo_eleitoral[i] = arqEntrada.ReadLine();
        eleitores_nome[i] = arqEntrada.ReadLine();
        eleitores_nascimento[i] = arqEntrada.ReadLine();
        eleitores_idade[i] = arqEntrada.ReadLine();
        string numero = arqEntrada.ReadLine();
        if (numero == "0") {
          votos_brancos++;
          continue;
        }
        int index = Array.IndexOf(candidatos_numero,numero);
        if (index == -1) {
          votos_nulos++;
          continue;
        }
        numero_de_votos_candidatos[index]++;
      }
      int maior_valor = numero_de_votos_candidatos[0];
      int maior_index = 0;
      for (int i = 1; i < numero_de_votos_candidatos.Length; i++) {
        if (numero_de_votos_candidatos[i] > maior_valor) {
          maior_valor = numero_de_votos_candidatos[i];
          maior_index = i;
        }
      }
      arqSaida.WriteLine("RESULTADO DA ELEIÇÃO");
      if (numero_de_votos_candidatos.Count(votos => votos == maior_valor) == 1) {
        arqSaida.WriteLine($"O vencedor foi o {candidatos_nome[maior_index]}, com {maior_valor} votos!");
      }
      else {
        arqSaida.WriteLine("Ocorreu um empate na eleição, será necessário uma nova eleição!");
      }
    }
    public static void Main() {
      Eleicao();
      arqEntrada.Close();
      arqSaida.Close();
    }
}
