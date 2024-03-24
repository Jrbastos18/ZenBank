namespace ZenBank.Models;
public class PessoaJuridica : Cliente
{
    public string RazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    private string Cnpj { get; set; } = string.Empty;
    private DateTime DataAbertura { get; set; }

    public PessoaJuridica(string razaoSocial, string nomeFantasia, string cnpj, DateTime dataAbertura, string endereco, string telefone) : base(endereco, telefone)
    {
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        Cnpj = cnpj;
        DataAbertura = dataAbertura;
    }

    public override string ToString()
    {
        return "\nRazão Social: " + RazaoSocial
            + "\nNome Fantasia: " + NomeFantasia
            + "\nCNPJ: " + Cnpj
            + "\nData de abertura: " + DataAbertura.ToString("dd/MM/yyyy")
            + "\nEndereco: " + Endereco
            + "\nTelefone: " + Telefone
            + "\nData de cadastro: " + DataCadastro.ToString("dd/MM/yyyy HH:mm:ss");
    }
}
