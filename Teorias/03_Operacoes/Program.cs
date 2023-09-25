Console.WriteLine("Digite o valor de X");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de Y");
int y = int.Parse(Console.ReadLine());

//? Exemplos de operadores aritméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //? Calculando o resto da divisao de x / 2
int restoDiv1 = y % 2;

//? Console para exibir na tela as variáveis em cada linha
Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}");
Console.WriteLine($"Resto: {resto}");

//? Operador ternário
//? Condição ? se verdade : senão
string resultado = (restoDiv2 == 0) ? $"O número {x} é par." : $"O número {x} é ímpar.";
Console.WriteLine(resultado);

string resultado2 = (restoDiv1 == 0) ? $"O número {y} é par." : $"O número {y} é ímpar.";
Console.WriteLine(resultado2);

int diaSemana = 3;
//? Aprendendo o Switch Case
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é domingo!");
        break;

    case 2:
        Console.WriteLine("Hoje é segunda!");
        break;

    case 3:
        Console.WriteLine("Hoje é terça!");
        break;

    case 4:
        Console.WriteLine("Hoje é quarta!");
        break;

    case 5:
        Console.WriteLine("Hoje é quinta!");
        break;

    case 6:
        Console.WriteLine("Hoje é sexta!");
        break;

    case 7:
        Console.WriteLine("Hoje é sábado!");
        break;

    default:
        Console.WriteLine("Dia inválido!!!!!!!!!!!!!!!!!!!!!!!");
        break;

}