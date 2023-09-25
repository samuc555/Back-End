using PanteraModel.Model;

class Program
{
    public static void Main()
    {
        var pantera1 = new Pantera();

        pantera1.EscrevaTamanho();
        pantera1.tamanho = decimal.Parse(Console.ReadLine());

        pantera1.EscrevaPeso();
        pantera1.peso = int.Parse(Console.ReadLine());

        pantera1.EscrevaCor();
        pantera1.cor = Console.ReadLine();

        pantera1.EscrevaEspecie();
        pantera1.especie = Console.ReadLine();

        pantera1.EscrevaAlimentacao();
        pantera1.alimentacao = Console.ReadLine();

        pantera1.ExibirDados();

        pantera1.acao();

        
        
        do
        {
            pantera1.fazer = int.Parse(Console.ReadLine());
            switch (pantera1.fazer)
            {
                case 0:
                    Console.WriteLine("Obrigado por ter criado sua pantera!");
                    System.Threading.Thread.Sleep(1000); 
                    break;
                
                case 1:
                    pantera1.Correr();
                    break;

                case 2:
                    pantera1.Cacar();
                    break;

                case 3:
                    pantera1.Reproduzir();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (pantera1.fazer != 0);


        
    }
}