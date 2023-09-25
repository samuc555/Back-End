using ContaCorrente.Model;

class Program
{

    public static void Main()
    {
        var conta1 = new ContaBancaria();

        conta1.BemVindo();
        conta1.titular = Console.ReadLine();
        System.Threading.Thread.Sleep(1000);

        conta1.BemVindoUsuario();
        conta1.Instrucoes();

        do
        {
            conta1.NumeroDigitado = int.Parse(Console.ReadLine());
            switch (conta1.NumeroDigitado)
            {
                case 0:
                    Console.WriteLine("Obrigado por ter utilizado nossos serviços!");
                    System.Threading.Thread.Sleep(1000);
                    break;

                case 1:
                    conta1.ConsultarSaldo();
                    break;

                case 2:
                    conta1.Depositar();
                    break;

                case 3:
                    conta1.Sacar();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (conta1.NumeroDigitado != 0);
    }

}