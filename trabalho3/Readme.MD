# Sistema de Controle de Temperaturas

## Descrição

Este projeto foi desenvolvido em C# utilizando estruturas de vetor e matriz para realizar o controle de temperaturas de cidades.

O sistema permite cadastrar cidades e armazenar as últimas 8 temperaturas registradas para cada uma delas, além de calcular médias individuais e gerais.

---

## Funcionalidades

### Menu Principal

O programa possui um menu interativo com as seguintes opções:

* **A** - Registrar temperatura de uma cidade
* **B** - Exibir temperaturas de uma cidade
* **C** - Exibir temperaturas gerais
* **D** - Exibir média de temperatura de uma cidade
* **E** - Exibir médias gerais
* **F** - Sair do sistema

---

## Estruturas Utilizadas

### Vetor

Foi utilizado um vetor para armazenar os nomes das cidades:

```csharp
string[] cidades = new string[n];
```

### Matriz

Foi utilizada uma matriz para armazenar as temperaturas:

```csharp
double[,] temperaturas = new double[n, 8];
```

* Linhas = cidades
* Colunas = últimas 8 temperaturas registradas

---

## Como Funciona

### Cadastro das cidades

O usuário informa quantas cidades deseja cadastrar e depois digita o nome de cada uma.

### Registro de temperatura

Ao registrar uma nova temperatura:

* As temperaturas antigas são deslocadas para a direita
* A nova temperatura é armazenada na posição 0
* O sistema mantém apenas as 8 últimas temperaturas

### Cálculo da média

O sistema soma todas as temperaturas da cidade e divide por 8.

---

## Tecnologias Utilizadas

* C#
* .NET
* Console Application

---

## Objetivo do Projeto

Praticar:

* Vetores
* Matrizes
* Estruturas de repetição
* Estruturas condicionais
* Menus interativos
* Manipulação de dados

---

## Exemplo de Uso

```text
MENU
A - Registrar temperatura de uma cidade
B - Exibir temperatura de uma cidade
C - Exibir temperaturas geral
D - Exibir temperatura média de uma cidade
E - Exibir temperaturas médias geral
F - Sair
```

---

## Autor

Projeto desenvolvido por Guilherme Ferreira.
