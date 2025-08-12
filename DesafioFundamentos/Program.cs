using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Clear();
Console.WriteLine("═══════════════════════════════════════════════════════");
Console.WriteLine("    Sejam Bem-Vindos ao AutoPark Estacionamento!      ");
Console.WriteLine("    Seu lugar na hora certa, porque estacionar        ");
Console.WriteLine("    nunca foi tão simples.                           ");
Console.WriteLine("═══════════════════════════════════════════════════════");
Console.WriteLine("\nPressione ENTER para cadastrar seus dados...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("═══════════════════════════════════════════");
Console.WriteLine("    Cadastro de Cliente");
Console.WriteLine("═══════════════════════════════════════════");

Console.Write("Nome do Cliente: ");
string nome = Console.ReadLine() ?? string.Empty;

Console.Write("CPF: ");
long cpf = 0;
while (!long.TryParse(Console.ReadLine(), out cpf))
{
    Console.WriteLine("CPF inválido! Digite apenas números.");
    Console.Write("CPF: ");
}

Console.WriteLine("\nAgora vamos cadastrar seu veículo:");
Console.Write("Placa: ");
string placa = Console.ReadLine() ?? string.Empty;

Console.Write("Modelo: ");
string modelo = Console.ReadLine() ?? string.Empty;

Console.Write("Marca: ");
string marca = Console.ReadLine() ?? string.Empty;

Console.Write("Cor: ");
string cor = Console.ReadLine() ?? string.Empty;

Console.Write("Tipo (Carro/Moto/Outro): ");
string tipo = Console.ReadLine() ?? string.Empty;

var veiculo = new Veiculo(placa, modelo, marca, cor, tipo);
var cliente = new Cliente(nome, cpf, veiculo);

Console.Clear();
Console.WriteLine("═══════════════════════════════════════════");
Console.WriteLine("    Cadastro Realizado com Sucesso!");
Console.WriteLine("═══════════════════════════════════════════");
Console.WriteLine($"Nome: {cliente.Nome}");
Console.WriteLine($"CPF: {cliente.Cpf}");
Console.WriteLine("\nDados do Veículo:");
Console.WriteLine($"Placa: {cliente.Veiculo.Placa}");
Console.WriteLine($"Modelo: {cliente.Veiculo.Modelo}");
Console.WriteLine($"Marca: {cliente.Veiculo.Marca}");
Console.WriteLine($"Cor: {cliente.Veiculo.Cor}");
Console.WriteLine($"Tipo: {cliente.Veiculo.Tipo}");
Console.WriteLine("═══════════════════════════════════════════");
Console.WriteLine("\nPressione ENTER para continuar para o menu principal...");
Console.ReadLine();
Console.Clear();

// Instancia a classe Estacionamento com o cliente inicial
Estacionamento es = new Estacionamento(cliente);

// Escolher tipo de vaga
es.EscolherTipoVaga(cliente.Veiculo.Placa);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
