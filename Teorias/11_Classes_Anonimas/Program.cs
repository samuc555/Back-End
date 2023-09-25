public class Program
{
    public static void Main()
    {
        //? Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "joao",
            idade = 17
        };
        var pessoa2 = new {
            nome = "maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa1 é {pessoa2.nome} e tem {pessoa2.email} anos");
        Console.WriteLine("");

        //? pessoa1.nome = "Douglas"

        var carro1 = new {
            marca = "Volkswagen",
            cor = "vermelho",
            ano = 2007,
            motor = 2.2
        };

        var carro2 = new {
            marca = "Porsche",
            cor = "verde e marrom",
            ano = 1939,
            motor = 2.2
        };
        
        Console.WriteLine($"O carro de marca {carro1.marca} tem a cor {carro1.cor}, é do ano de {carro1.ano}, e tem um motor {carro1.motor}.");
        Console.WriteLine($"O carro de marca {carro2.marca} tem a cor {carro2.cor}, é do ano de {carro2.ano}, e tem um motor {carro2.motor}.");
    }
}