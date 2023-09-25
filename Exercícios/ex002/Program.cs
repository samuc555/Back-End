Console.WriteLine("Informe a placa do seu carro");

string placa = Console.ReadLine();
int ultimoNum = int.Parse(placa.Substring(6));

switch (ultimoNum){
    case 1: 
        Console.WriteLine("Seu carro pode rodar na segunda");
        break;

    case 2: 
        Console.WriteLine("Seu carro pode rodar na segunda");
        break;

    case 3: 
        Console.WriteLine("Seu carro pode rodar na terça");
        break;

    case 4: 
        Console.WriteLine("Seu carro pode rodar na terça");
        break;

    case 5: 
        Console.WriteLine("Seu carro pode rodar na quarta");
        break;

    case 6: 
        Console.WriteLine("Seu carro pode rodar na quarta");
        break;

    case 7: 
        Console.WriteLine("Seu carro pode rodar na quinta");
        break;

    case 8: 
        Console.WriteLine("Seu carro pode rodar na quinta");
        break;

    case 9: 
        Console.WriteLine("Seu carro pode rodar na sexta");
        break;

    case 0: 
        Console.WriteLine("Seu carro pode rodar na sexta");
        break;

    default: 
        Console.WriteLine("Placa Inválida");
        break;

}