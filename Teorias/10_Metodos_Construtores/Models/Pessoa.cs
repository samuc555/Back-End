namespace Models
{
    public class Pessoa
    {
        //? Atributos da nossa classe Pessoa
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        private int anoNascimento { get; set; }

        //? Método construtor da classe program
        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }

        //? Método da Classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void informacoes()
        {
            Console.WriteLine($"A idade de {nome} é {idade}. O e-mail de {nome} é {email}. O ano de nascimento de {nome} é {anoNascimento}");
        }

    }
}