class Program
{
    public static void Main()
    {
        ListaDoChurrasco();
        SonhosDeConsumo();
    }

    public static void ListaDoChurrasco()
    {
        string[] lista = new string[6];

        Console.WriteLine("Insira 5 itens para levar ao churrasco");
        lista[0] = Console.ReadLine();
        lista[1] = Console.ReadLine();
        lista[2] = Console.ReadLine();
        lista[3] = Console.ReadLine();
        lista[4] = Console.ReadLine();

        Console.WriteLine("Insira a quantidade de carne a ser comprada");
        lista[5] = Console.ReadLine();

        Array.Sort(lista);
        foreach (string i in lista)
        {

            Console.WriteLine(i);
        }
    }

    public static void SonhosDeConsumo()
    {
        string[] sonhos = new string[3];
        int[] preco = new int[3];

        Console.WriteLine("Insira seu primeiro sonho!");
        sonhos[0] = Console.ReadLine();
        Console.WriteLine("Insira seu preço!");
        preco[0] = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira seu segundo sonho!");
        sonhos[1] = Console.ReadLine();
        Console.WriteLine("Insira seu preço!");
        preco[1] = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira seu terceiro sonho!");
        sonhos[2] = Console.ReadLine();
        Console.WriteLine("Insira seu preço!");
        preco[2] = int.Parse(Console.ReadLine());

        Console.WriteLine($"{sonhos[0]} R${preco[0]}");
        Console.WriteLine($"{sonhos[1]} R${preco[1]}");
        Console.WriteLine($"{sonhos[2]} R${preco[2]}");

        Console.WriteLine("A soma dos valores dos seus sonhos é:");
        Console.WriteLine($"R${preco[0] + preco[1] + preco[2]}");

    }
}