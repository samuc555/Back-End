//? Exercício 001 - calculando a média de 3 notas de 1 aluno

//? Receber o nome do aluno e armazenar em uma variável do tipo string
    Console.WriteLine("Digite o nome do aluno");
    string nomeAluno = Console.ReadLine();
//? Receber a nota 1, converter e armazenar em uma variável int
    Console.WriteLine("Digite a primeira nota do aluno");
    int nota1 = int.Parse(Console.ReadLine());
//? Receber a nota 2, converter e armazenar em uma variável int
    Console.WriteLine("Digite a segunda nota do aluno");
    int nota2 = int.Parse(Console.ReadLine());
//? Receber a nota 3, converter e armazenar em uma variável int
    Console.WriteLine("Digite a terceira nota do aluno");
    int nota3 = int.Parse(Console.ReadLine());
//? Declarar uma variável do tipo int, para receber a média das notas (nota1 + nota2 + nota3) / 3
    int media = (nota1 + nota2 + nota3) / 3;
//? Exibir uma mensagem se o aluno está aprovado considerando nota acima de 7
    string resultado = (media >= 7) ? $"O aluno {nomeAluno} foi aprovado. Média {media}" : $"O aluno {nomeAluno} foi reprovado. Média {media}";
    Console.WriteLine(resultado);

