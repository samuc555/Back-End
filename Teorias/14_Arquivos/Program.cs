using System.IO;

public class Program
{
    public static string CaminhoArquivo = "Arquivo/arquivo.txt";
    public static void Main()
    {
        //? Chamando o método gravar arquivo
         GravarArquivo();

        //? Chamando o método ler arquivo
        LerArquivo();
    }

    //? instanciando um objeto da classe StreamWriter para ler um arquivo
    public static void LerArquivo()
    {
        
        //? Verificar se o arquivo existe
        if (File.Exists(CaminhoArquivo) == false)
        {
            //? Criando meu arquivo.txt. Este comando é executado quando a verificação no if é falsa, ou seja, o arquivo não existe.
            File.Create(CaminhoArquivo);
        }

        using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
        {
            string linha;
            //? Fazendo o while para ler linha por linha que contém no arquivo
            while ((linha = arquivo.ReadLine()) != null)
            {
                //? Escrevendo no console o conteúdo da linha
                Console.WriteLine(linha);
            }
        }
    }
    public static void GravarArquivo()
    {
        try
        {
            //? instanciando um objeto da classe StreamWriter para gravar em um arquivo
            using (StreamWriter arquivo = new StreamWriter(CaminhoArquivo, true))
            {
                Console.WriteLine("Digite um texto para gravar no arquivo .txt");

                /* 
                # string Mensagem = Console.ReadLine();
                # arquivo.WriteLine(Mensagem);
                */

                arquivo.WriteLine(Console.ReadLine());
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }
    }
}