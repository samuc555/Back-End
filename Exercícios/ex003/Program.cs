Console.WriteLine("Informe o número do mês");
int mes = int.Parse(Console.ReadLine());
switch (mes){
    case 1: 
        Console.WriteLine("O mês de janeiro tem 31 dias");
        break;

    case 2: 
        Console.WriteLine("O mês de fevereiro tem 28 dias e 29 em anos bissextos");
        break;

    case 3: 
        Console.WriteLine("O mês de março em 31 dias");
        break;

    case 4: 
        Console.WriteLine("O mês de abril tem 30 dias");
        break;

    case 5: 
        Console.WriteLine("O mês de maio tem 31 dias");
        break;

    case 6: 
        Console.WriteLine("O mês de junho tem 30 dias");
        break;

    case 7: 
        Console.WriteLine("O mês de julho tem 31 dias");
        break;

    case 8: 
        Console.WriteLine("O mês de agosto tem 31 dias");
        break;

    case 9: 
        Console.WriteLine("O mês de setembro tem 30 dias");
        break;

    case 10: 
        Console.WriteLine("O mês de outubro tem 31 dias");
        break;

    case 11: 
        Console.WriteLine("O mês de novembro tem 30 dias");
        break;

    case 12: 
        Console.WriteLine("O mês de dezembro tem 31 dias");
        break;

    default: 
        Console.WriteLine("mes inválido.");
        break;

}