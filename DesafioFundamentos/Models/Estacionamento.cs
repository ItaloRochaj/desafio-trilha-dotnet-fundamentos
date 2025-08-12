namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private const decimal PrecoTurnoManha = 50.0m;
        private const decimal PrecoTurnoTarde = 70.0m;
        private const decimal PrecoTurnoNoite = 100.0m;
        private const decimal PrecoDiaria = 200.0m;
        private const decimal PrecoHora = 15.0m;
        
        private List<string> veiculos = new List<string>();
        private List<Cliente> clientes = new List<Cliente>();
        private Dictionary<string, (string tipo, DateTime entrada, string periodo)> vagasOcupadas = new Dictionary<string, (string, DateTime, string)>();

        public Estacionamento(Cliente clienteInicial = null)
        {
            if (clienteInicial != null)
            {
                clientes.Add(clienteInicial);
                veiculos.Add(clienteInicial.Veiculo.Placa);
            }
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite os dados do veículo para estacionar:\n");
            
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

            Veiculo veiculo = new Veiculo(placa, modelo, marca, cor, tipo);
            Cliente cliente = new Cliente("Cliente Rotativo", 0, veiculo);
            clientes.Add(cliente);
            veiculos.Add(placa);
            
            EscolherTipoVaga(placa);
        }

        public void EscolherTipoVaga(string placa)
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("    Escolha o tipo de vaga:               ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("1 - Vaga Rotativa");
            Console.WriteLine("2 - Vaga Reservada");
            
            string opcao = Console.ReadLine() ?? string.Empty;
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    ConfigurarVagaRotativa(placa);
                    break;
                case "2":
                    ConfigurarVagaReservada(placa);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    EscolherTipoVaga(placa);
                    break;
            }
        }

        private void ConfigurarVagaRotativa(string placa)
        {
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("    Configurar Vaga Rotativa              ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("Escolha o período de permanência:");
            Console.WriteLine("1 - Por Hora (R$ 15,00/hora)");
            Console.WriteLine("2 - Turno Manhã (R$ 50,00)");
            Console.WriteLine("3 - Turno Tarde (R$ 70,00)");
            Console.WriteLine("4 - Turno Noite (R$ 100,00)");
            Console.WriteLine("5 - Diária (R$ 200,00)");

            string opcao = Console.ReadLine() ?? string.Empty;
            decimal valor = 0;
            string periodo = "";

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a quantidade de horas (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out int horas) && horas >= 1 && horas <= 5)
                    {
                        valor = PrecoHora * horas;
                        periodo = $"{horas} hora(s)";
                    }
                    break;
                case "2":
                    valor = PrecoTurnoManha;
                    periodo = "Turno Manhã";
                    break;
                case "3":
                    valor = PrecoTurnoTarde;
                    periodo = "Turno Tarde";
                    break;
                case "4":
                    valor = PrecoTurnoNoite;
                    periodo = "Turno Noite";
                    break;
                case "5":
                    valor = PrecoDiaria;
                    periodo = "Diária";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    ConfigurarVagaRotativa(placa);
                    return;
            }

            vagasOcupadas[placa] = ("Rotativa", DateTime.Now, periodo);
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("    Vaga Rotativa Cadastrada com Sucesso!");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Período: {periodo}");
            Console.WriteLine($"Valor: R$ {valor:F2}");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }

        private void ConfigurarVagaReservada(string placa)
        {
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("    Configurar Vaga Reservada             ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("Escolha o período de reserva:");
            Console.WriteLine("1 - Turno Manhã (R$ 50,00)");
            Console.WriteLine("2 - Turno Tarde (R$ 70,00)");
            Console.WriteLine("3 - Turno Noite (R$ 100,00)");
            Console.WriteLine("4 - Diária (R$ 200,00)");

            string opcao = Console.ReadLine() ?? string.Empty;
            decimal valor = 0;
            string periodo = "";

            switch (opcao)
            {
                case "1":
                    valor = PrecoTurnoManha;
                    periodo = "Turno Manhã";
                    break;
                case "2":
                    valor = PrecoTurnoTarde;
                    periodo = "Turno Tarde";
                    break;
                case "3":
                    valor = PrecoTurnoNoite;
                    periodo = "Turno Noite";
                    break;
                case "4":
                    valor = PrecoDiaria;
                    periodo = "Diária";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    ConfigurarVagaReservada(placa);
                    return;
            }

            vagasOcupadas[placa] = ("Reservada", DateTime.Now, periodo);
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("    Vaga Reservada Cadastrada com Sucesso!");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Período: {periodo}");
            Console.WriteLine($"Valor: R$ {valor:F2}");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine() ?? string.Empty;

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                var vaga = vagasOcupadas.GetValueOrDefault(placa);
                decimal valorTotal = 0;

                if (vaga != default)
                {
                    switch (vaga.periodo)
                    {
                        case "Turno Manhã":
                            valorTotal = PrecoTurnoManha;
                            break;
                        case "Turno Tarde":
                            valorTotal = PrecoTurnoTarde;
                            break;
                        case "Turno Noite":
                            valorTotal = PrecoTurnoNoite;
                            break;
                        case "Diária":
                            valorTotal = PrecoDiaria;
                            break;
                        default:
                            if (vaga.periodo.Contains("hora"))
                            {
                                int horas = int.Parse(vaga.periodo.Split(' ')[0]);
                                valorTotal = PrecoHora * horas;
                            }
                            break;
                    }

                    veiculos.Remove(placa.ToUpper());
                    var cliente = clientes.FirstOrDefault(c => c.Veiculo.Placa == placa);
                    if (cliente != null)
                        clientes.Remove(cliente);
                    
                    vagasOcupadas.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("═══════════════════════════════════════════");
                Console.WriteLine("    Veículos Estacionados                 ");
                Console.WriteLine("═══════════════════════════════════════════");
                
                foreach(var cliente in clientes)
                {
                    var vaga = vagasOcupadas.GetValueOrDefault(cliente.Veiculo.Placa);
                    Console.WriteLine($"\nPlaca: {cliente.Veiculo.Placa}");
                    Console.WriteLine($"Modelo: {cliente.Veiculo.Modelo}");
                    Console.WriteLine($"Marca: {cliente.Veiculo.Marca}");
                    Console.WriteLine($"Cor: {cliente.Veiculo.Cor}");
                    Console.WriteLine($"Tipo: {cliente.Veiculo.Tipo}");
                    if (vaga != default)
                    {
                        Console.WriteLine($"Tipo de Vaga: {vaga.tipo}");
                        Console.WriteLine($"Período: {vaga.periodo}");
                        Console.WriteLine($"Entrada: {vaga.entrada}");
                    }
                    Console.WriteLine("───────────────────────────────────");
                }
            }
            else
            {
                Console.WriteLine("═══════════════════════════════════════════");
                Console.WriteLine("    Não há veículos estacionados          ");
                Console.WriteLine("═══════════════════════════════════════════");
            }
        }
    }
}
