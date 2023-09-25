class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i += 5)
        {
            Console.WriteLine($"Estou passando pela {i}ª vez no for");
        }

        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($"A variável sesi vale {sesi}");
        }

        int numero = 87;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{numero} x {cont} = {numero * cont}");
        }

        //? Declarando um vetor no C# com 34 posições 
        string[] alunos = new string[35];

        //? Atribuíndo valores ao nosso vetor 
        alunos[1] = "Abner";
        alunos[2] = "Adalberto Kaio";
        alunos[3] = "Ana Carolina";
        alunos[34] = "Samuel";

        foreach (string aluno in alunos)
        {
            if (aluno != null)
                Console.WriteLine(aluno);
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;

        int laura = 0; //? Soma
        int jorge = 0; //? Maior
        int bianca = 100; //? Menor
        foreach (int enzo in cadeiras)
        {
            laura = laura + enzo;
            if (enzo > jorge)
            {
                jorge = enzo;
            }

            if (enzo < bianca)
            {
                bianca = enzo;
            }
        }
        Console.WriteLine($"Soma: {laura}, Maior {jorge} menor {bianca}");

        Array.Sort(cadeiras);

        for (int x = 0; x < cadeiras.Length; x++)
        {
            Console.WriteLine($"Pos {x} - valor {cadeiras[x]}");
        }
    }
}