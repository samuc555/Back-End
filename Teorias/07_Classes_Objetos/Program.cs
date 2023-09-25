//? Sempre que formos usar bibliotecas ou classes já criadas de terceiros, importamos utilizando o "using".
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //? Criando uma variável aluno1 e instanciando da classe Aluno.
        //? Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();

        //? Atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Samuel";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";

        //? Chamando o método da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();

        //-------------------------------------------------------------------//

        //? Criando uma variável aluno1 e instanciando da classe Aluno.
        //? Ou seja, estamos criando nosso objeto
        var aluno2 = new Aluno();

        //? Atribuindo um valor ao atributo nome do aluno1
        aluno2.nome = "Jacinto Pinto";
        aluno2.idade = 49;
        aluno2.turma = "2º EF";

        //? Chamando o método da classe Aluno
        aluno2.Apresentar();
    }
}