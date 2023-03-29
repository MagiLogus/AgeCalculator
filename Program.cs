// Crie um programa para calcular a idade de uma pessoa pelo seu ano de nascimento 

// Algoritmo 
// Entrada: meses, dias, horas, minutos
// Proscessamento: data de nascimento - ano atual // anos * 52 semanas 

//Entrada 
Console.BackgroundColor =ConsoleColor.Black;

Console.WriteLine(@$"
--------------------------------
|       Programa para          |
|     calcular sua Idade       |
|      Em anos e semanas       |
--------------------------------
");

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo {nome} !");

Console.WriteLine($"Digite seu ano de nascimento: ");
int ano = int.Parse(Console.ReadLine());

// Processamento 
int anoAtual = DateTime.Now.Year;
int anos = (anoAtual-ano);
int emSemanas = (anos*52);

// Saida
Console.WriteLine($"{nome} você tem {anos} anos ou {emSemanas} semanas !");