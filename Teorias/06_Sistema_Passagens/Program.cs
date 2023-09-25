class Program
{
    public static string[] poltronas = new string[43];
    

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("           Bem-vindo ao Bus-anfa           ");
        Console.WriteLine("                                           ");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("                                            ");
        Console.WriteLine("    Contamos com 42 lugares disponíveis    ");
        Console.WriteLine("                                           ");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";

        do
        {
            Console.WriteLine("------------------- MENU ------------------");
            Console.WriteLine("|        1 - Para comprar passagem        |");
            Console.WriteLine("|      2 - Para poltronas disponiveis     |");
            Console.WriteLine("|         0 - Para fechar o sistema       |");
            Console.WriteLine("-------------------------------------------");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado! Volte sempre!");
                    System.Threading.Thread.Sleep(1000); //? Espera de 1s
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();

                    break;
                default:
                    Console.WriteLine("Opçao invalida");
                    break;
            }
        } while (opcao != "0");
    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("                                           ");
        Console.WriteLine("     Quantas passagens deseja comprar?     ");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine("                                           ");
            Console.WriteLine($"    Digite a poltrona da {i}º passagem:   ");
            
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("                                           ");
            Console.WriteLine("        Informe o nome do passageiro       ");
            string nome = Console.ReadLine();

            MarcarPoltronas(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltronas(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponiveis");
        for (int i = 1; i <= 42; i++) 
        {
            if (poltronas[i] == null ){
                Console.WriteLine($"Nº {i}");
            }
        }
    }
}