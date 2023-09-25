//? Classe Pai que será herdada pelo filho - SuperClasse
class Animal
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

//? Classe filha que herdará da classe pai
//? Receberá todos os atributos e métodos da SuperClasse
class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine($"au au - Disse o cachorro {cor}");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando");
    }
}

class Program
{
    static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "Caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}