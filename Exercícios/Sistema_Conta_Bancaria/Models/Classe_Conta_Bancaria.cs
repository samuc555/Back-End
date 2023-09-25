namespace ContaCorrente.Model
{
    public class ContaBancaria
    {
        //* Atributos para armazenar os dados relacionados à conta.
        public string titular { get; set; }
        public float saldo { get; set; }

        //* Variante para receber o número que o usuário irá digitar para executar uma função.
        public int NumeroDigitado { get; set; }

        //----------------------------------------------------------------------//

        //* Método para receber o usuário.
        public void BemVindo()
        {
            Console.WriteLine("Seja bem-vindo ao Sistema CCBE (Conta Corrente com Back End)");
            Console.WriteLine(""); //? Espaço em branco para pular linha

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Por favor, digite o seu nome de usuário.");
            Console.WriteLine(""); //? Espaço em branco para pular linha
        }
        public void BemVindoUsuario()
        {
            Console.WriteLine($"Seja bem vindo {titular}! O que deseja fazer?");
            Console.WriteLine(""); //? Espaço em branco para pular linha
        }

        //* Método para exibir as instruções de uso do sistema
        public void Instrucoes()
        {
            Console.WriteLine("Digite 1 para consultar seu saldo");
            Console.WriteLine("Digite 2 para depositar em sua conta");
            Console.WriteLine("Digite 3 para sacar dinheiro de sua conta");
            Console.WriteLine("Digite 0 para sair do sistema");
        }

        //* Método para consultar o saldo da conta.
        public void ConsultarSaldo()
        {
            if (saldo == null)
            {
                saldo = 0;
                Console.WriteLine("Seu saldo = R$0,00");
            }
            else
            {
                Console.WriteLine($"Seu saldo é de R${saldo}");
            }

        }

        //* Método para depositar dinheiro na conta bancária.
        public void Depositar()
        {
            Console.WriteLine("Digite o valor a ser depositado");
            float ValorDepositado = float.Parse(Console.ReadLine());
            if (ValorDepositado <= 0)
            {
                Console.WriteLine("Valor inválido para depósito");
                Console.WriteLine(""); //? Espaço em branco para pular linha
            }
            else
            {
                saldo += ValorDepositado;
                Console.WriteLine("Valor depositado com sucesso!");
                Console.WriteLine(""); //? Espaço em branco para pular linha
                System.Threading.Thread.Sleep(1000);
                Instrucoes();
            }


        }

        //* Método para sacar dinheiro da conta bancária.
        public void Sacar()
        {
            Console.WriteLine("Digite o valor a ser sacado");
            float ValorSacado = float.Parse(Console.ReadLine());
            if (ValorSacado > saldo || ValorSacado == 0 || ValorSacado == null)
            {
                Console.WriteLine("Valor inválido para saque");
                Console.WriteLine(""); //? Espaço em branco para pular linha
            }
            else
            {
                //? this => Este
                //? This refere-se a classe atual, no caso estamos atribuindo
                //? O valor a variavel Saldo pertencente a ESTA classe
                this.saldo -= ValorSacado;
                Console.WriteLine("Valor sacado com sucesso!");
                Console.WriteLine(""); //? Espaço em branco para pular linha

                System.Threading.Thread.Sleep(1000);
                Instrucoes();
            }
        }
    }
}