//Imprime um texto na tela.
Console.WriteLine("Hello World!");

Console.WriteLine("Seja bem vindo ao meu primeiro programa!");

string nome = "Pedro Oliveira";
Console.WriteLine(nome + " é meu nome!");

// Criação de duas variaveis.
string nome;
int Idade;

Console.WriteLine("Qual é seu nome?");

// Lê o mome digitado pelo usuário e armazena na variável nome.
nome = Console.ReadLine();
Console.WriteLine("Prazer em conhecer" + nome + "!");

Console.WriteLine("Qual é a sua idade?");
Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Você tem " + idade + " anos de idade.")