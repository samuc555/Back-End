class Program
{

    public static void Main()
    {
        Console.WriteLine("Insira o número a ser calculado");
        int Numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"O dobro do seu número é: {Dobro(Numero)}");
        Console.WriteLine($"A metade do seu número é: {Metade(Numero)}");
        Tabuada();
        ResumoSalarios();
    }

    public static int Dobro(int valor)
    {
        int Dobro = valor * 2;
        return Dobro;
    }

    public static int Metade(int valor)
    {
        int Metade = valor / 2;
        return Metade;
    }

    public static void Tabuada()
    {
        Console.WriteLine("Insira o número para calcular a tabuada");
        int NumeroTabuada = int.Parse(Console.ReadLine());
        int contador = 1;

        while (contador <= 100)
        {
            Console.WriteLine($" {NumeroTabuada} x {contador} = {NumeroTabuada * contador}");

            contador++;
        }
    }

    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do
        {
            Console.WriteLine("Digite o salário do empregado");
            salarioEmpregado = int.Parse(Console.ReadLine());

            if (salarioEmpregado > 0)
            somaSalarios = somaSalarios + salarioEmpregado;

            //somaSalarios += salarioEmpregado;
            if (salarioEmpregado > maiorSalario)
            {
                maiorSalario = salarioEmpregado;
            }
            if (salarioEmpregado < menorSalario && salarioEmpregado > 0)
            {
                menorSalario = salarioEmpregado;
            }


        } while (salarioEmpregado > 0);

        Console.WriteLine($"A soma dos salários é {somaSalarios} o maior salário é {maiorSalario} e o menor salário é {menorSalario}");
    }
}