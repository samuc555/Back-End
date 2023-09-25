using System.Collections.Generic;
using Sesi.Models;

public class Program
{

    public static void Main()
    {
        //@ Criando uma lista
        //? Declarando uma lista de inteiros
        List<int> listaNumeros = new List<int>(); //$ Entre os <>, se coloca o tipo da lista


        //? Adicionando elementos na lista
        listaNumeros.Add(10); //$ Item está na posição [0]
        listaNumeros.Add(20); //$ Item está na posição [1]
        listaNumeros.Add(45); //$ Item está na posição [2]

        //* Assim como nos Arrays, as posições começam a partir do 0.

        //? Exibindo elementos específicos da lista no console
        Console.WriteLine(listaNumeros[0]);
        Console.WriteLine(listaNumeros[1]);
        Console.WriteLine(listaNumeros[2]);

        //* Ao exibir elementos da lista, deve-se colocar um [] com a posição do elemento após o nome da lista.

        //? Comando para exibir a quantidade de itens na lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos.");

        //? Adicionando mais um elemento na elementos
        listaNumeros.Add(45); //$ Item está na posição [3]

        //? Exibindo novamente a quantidade de elementos para que o novo item adicionado apareça na contagem
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos.");
        Console.WriteLine(""); //$ Espaço vazio para separar
        Console.WriteLine(""); //$ Espaço vazio para separar

        //@ nova lista, com nomes.
        List<string> listaNomes = new List<string>();
        Console.WriteLine("Escreva um nome!");

        //? Adicionando elementos à lista utilizando o Console.ReadLine();
        listaNomes.Add(Console.ReadLine());
        Console.WriteLine(""); //$ Espaço vazio para separar

        Console.WriteLine("Escreva um nome!");
        listaNomes.Add(Console.ReadLine());
        Console.WriteLine(""); //$ Espaço vazio para separar

        Console.WriteLine("Escreva um nome!");
        listaNomes.Add(Console.ReadLine());
        Console.WriteLine(""); //$ Espaço vazio para separar

        //? Exibindo no console a quantidade de elementos na lista, e também exibindo cada elemento.
        Console.WriteLine($"Sua lista tem {listaNomes.Count} posições, cada uma delas sendo:");
        Console.WriteLine(listaNomes[0]);
        Console.WriteLine(listaNomes[1]);
        Console.WriteLine(listaNomes[2]);
        Console.WriteLine(""); //$ Espaço vazio para separar

        //@ Criando uma lista já atribuindo valores 
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elementos na lista números: {numeros.Count}");

        //? Removendo elementos da lista
        numeros.Remove(2); //$ Remover o elemento 2
        numeros.RemoveAt(1); //$ Remover o elemento no indice 1
        numeros.RemoveRange(2, 2); //$ Pegando a posição 2, e removendo 2 elementos a partir dela

        //? Substituindo informação do item da lista
        numeros[0] = 100;

        //? Exibindo TODOS os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Estes são os nomes da sua lista:");
        foreach (string i in listaNomes)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(""); //$ Espaço vazio para separar

        //? Criando uma lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //? Adicionando um novo aluno à minha lista
        Aluno novoAluno = new Aluno("Pedro", 10);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //? Exibindo lista de Alunos
        Console.WriteLine("Lista Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }

        //? Criando uma nova lista, porém ordenando por nome
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        //? LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
        .Where(aluno => aluno.idade == 17)
        .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }

    }
}