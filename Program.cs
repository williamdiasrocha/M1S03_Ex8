
using PareAqui;

List<Carro> carros = new List<Carro>();
string opcao;

do{

    Console.WriteLine("Olá, bem vindo ao Estacionamento PARE AQUI!");
    Console.WriteLine("Selecione uma opção do menu:");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Marcar Entrada");
    Console.WriteLine("3 - Marcar Saída");
    Console.WriteLine("4 - Consultar Histórico");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();

    if(opcao == "1")
    {
        CadastrarCarro();
    }

    if(opcao == "2")
    {
        GerarTicket();
    }

    if(opcao == "3")
    {
        FecharTicket();
    }



}while (opcao != "5");


void CadastrarCarro()
{
   Carro carro = new Carro();
        Console.WriteLine("Digite a placa do carro:");
        carro.Placa = Console.ReadLine();
        Console.WriteLine("Digite o modelo do carro:");
        carro.Modelo = Console.ReadLine();
        Console.WriteLine("Digite qual cor do carro:");
        carro.Cor = Console.ReadLine();
        Console.WriteLine("Digite qual a Marca do carro:");
        carro.Marca = Console.ReadLine();
        carros.Add(carro);
}

Carro ObterCarro(string placa)
{
    foreach(var carro in carros){
        if (placa == carro.Placa){
            return carro;
        }
    }
    return null;
}

void GerarTicket()
{
    Console.WriteLine("Qual a placa do carro:");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    if(carro == null){
        Console.WriteLine("Carro não cadastrado no sistema.");
        return;
    }

    foreach(var ticket in carro.ListaTickets){
        if(ticket.Ativo == true){
            Console.WriteLine("Carro já cadastrado no sistema e no estacionamento.");
            return;
        }
    }

    Ticket ticketNovo = new Ticket();
    carro.ListaTickets.Add(ticketNovo);
    Console.WriteLine("Ticket Gerado com sucesso!");

}

void FecharTicket()
{
    Console.WriteLine("Qual a placa do carro:");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    if(carro == null){
        Console.WriteLine("Carro não cadastrado no sistema.");
        return;
    }
    Ticket ticketAberto = null;
    foreach(var ticket in carro.ListaTickets){
        if(ticket.Ativo == true){
            ticketAberto = ticket;
        }
    }
    if(ticketAberto == null){
        Console.WriteLine("Não há tickets em aberto para o carro.");
        return;
    }

    
}
