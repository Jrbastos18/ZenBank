namespace ZenBank.Models;
public class PessoaFisica : Cliente
{
    public string Nome { get; set; } = string.Empty;
    private string Cpf { get; set;} 
    private DateTime DataNascimento { get; set; } 

    public PessoaFisica(string nome, string cpf, DateTime dataNascimento, string endereco, string telefone) : base(endereco, telefone)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
    }

    public override string ToString()
    {
        return "\nNome: " + Nome
            + "\nCPF: " + Cpf
            + "\nData de nascimento: " + DataNascimento.ToString("dd/MM/yyyy")
            + "\nEndereco: " + Endereco
            + "\nTelefone: " + Telefone
            + "\nData de cadastro: " + DataCadastro.ToString("dd/MM/yyyy HH:mm:ss");
    }
}
