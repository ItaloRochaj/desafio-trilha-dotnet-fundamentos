namespace DesafioFundamentos.Models
{
    public class Cliente
    {
        public string Nome { get; set; } = string.Empty;
        public long Cpf { get; set; }
        public Veiculo Veiculo { get; set; }

        public Cliente(string nome, long cpf, Veiculo veiculo)
        {
            Nome = nome;
            Cpf = cpf;
            Veiculo = veiculo;
        }
    }
}
