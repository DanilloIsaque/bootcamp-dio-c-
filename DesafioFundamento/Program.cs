using DesafioFundamento.Models;

Estacionamento estacionamento = new Estacionamento(10.00m,5.00m);

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Adicionar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Consultar");
    Console.WriteLine("0 - Encerrar programa");
    string opcao = Console.ReadLine(); // Solicita a opção do usuário

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do carro ou digite 'voltar' para retornar ao menu ");
            string placa = Console.ReadLine();
            placa = placa.Trim();
            if (!placa.Equals("voltar", StringComparison.OrdinalIgnoreCase))
            {
                estacionamento.adicionarVeiculo(placa);
            }
            break;

        case "2":
            Console.WriteLine("Digite a placa do carro ou digite 'voltar' para retornar ao menu ");
            string placaRemocao = Console.ReadLine();
            placaRemocao = placaRemocao.Trim();
            if (!placaRemocao.Equals("voltar", StringComparison.OrdinalIgnoreCase))
            {
                estacionamento.removerVeiculo(placaRemocao);
            }
            break;

        case "3":
            estacionamento.consultarVeiculos();
            break;

        case "0":
            Console.WriteLine("Encerrando...");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
