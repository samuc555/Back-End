using Models;

public class Program
{
    public static void Main()
    {
        //? Criando um objeto da classe Pessoa
        //? instanciando sem um método constutor
        /*
        var pessoa1 = new Pessoa();
        pessoa1.nome = "Ahnhanahna";
        pessoa1.idade = 25;
        pessoa1.Cantar();

        //? Alternativa para criação de um objeto sem construtor 
        Pessoa pessoa2 = new Pessoa{
            nome = "ehehnhenhen",
            idade = 172
        };
        pessoa2.Cantar();
        */
        //? Alternativa mais correta: 
        Pessoa pessoa1 = new Pessoa("Douglas", 35, "douglas.camata@docente.senai.br");
        pessoa1.Cantar();
        pessoa1.informacoes();

        Pessoa pessoa2 = new Pessoa(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
        pessoa2.Cantar();
        pessoa2.informacoes();

    }
}