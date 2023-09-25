//? Somente declarando uma variável do tipo inteira e sem valor
/*int num1;

//? Declarando uma variável do tipo inteiro e atribuindo valor 5
int num2 = 5;

//? Declarando variável string
string nomeAluno = "Paulo";

//? Declarando variável booleana tipo lógico (true or false)
bool resultado = true;

//? Variável do tipo double valor com várias casas decimais
double coordenada = 1.803324965789;

//? Variável do tipo decimal - utilizada para valores
decimal valor = 1.80M;*/

int idade = 16;
string meuNome = "Samuel";
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine("Em qual cidade você nasceu?");
//? Readline serve apenas para que eu receba uma informação do usuário e armazeno em uma variável
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você masceu em {nomeCidade}");