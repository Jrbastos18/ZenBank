namespace ZenBank.Models;
public class PessoaFisica : Cliente
{
    public string Nome { get; set; } = string.Empty;
    private int Cpf { get; set;} 
    private DateTime DataNascimento { get; set; } 

    public PessoaFisica(string endereco, string telefone, string nome, int cpf, DateTime dataNascimento) : base(endereco, telefone)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
    }
}
