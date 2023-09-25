namespace PanteraModel.Model
{
    public class Pantera
    {
        public decimal tamanho { get; set;}
        public int peso { get; set;}
        public string cor { get; set;}
        public string especie { get; set;}
        public string alimentacao { get; set;}
        public int fazer { get; set;}

        public void EscrevaTamanho()
        {
            Console.WriteLine("Digite o tamanho de sua pantera (em cm)");
        }
        public void EscrevaPeso()
        {
            Console.WriteLine("Digite o peso de sua pantera (em kg)");
        }
        public void EscrevaCor()
        {
            Console.WriteLine("Digite a cor de sua pantera");
        }
        public void EscrevaEspecie()
        {
            Console.WriteLine("Digite a especie de sua pantera");
        }
        public void EscrevaAlimentacao()
        {
            Console.WriteLine("Digite a alimentacao de sua pantera");
        }

        public void acao(){
            Console.WriteLine("O que a pantera fará?");
            Console.WriteLine("Digite 1 para ela correr");
            Console.WriteLine("Digite 2 para ela caçar");
            Console.WriteLine("Digite 3 para ela reproduzir 😏");
            Console.WriteLine("Digite 0 para fechar o sistema.");
        }
        public void Correr()
        {
            Console.WriteLine("           ");
            Console.WriteLine("Pantera está correndo");
        }
        public void Cacar()
        {
            Console.WriteLine("           ");
            Console.WriteLine("Pantera está caçando");
        }
        public void Reproduzir()
        {
            Console.WriteLine("           ");
            Console.WriteLine("Pantera está reproduzindo");
        }
        public void ExibirDados()
        {
            Console.WriteLine("           ");
            Console.WriteLine($"{tamanho}cm");
            Console.WriteLine($"{peso}kg");
            Console.WriteLine($"{cor}");
            Console.WriteLine($"{especie}");
            Console.WriteLine($"{alimentacao}");
            Console.WriteLine("           ");
        }
    }
}