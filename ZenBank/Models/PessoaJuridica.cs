namespace ZenBank.Models;
public class PessoaJuridica : Cliente
{
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    private int Cnpj { get; set; }
    private DateTime DataAbertura { get; set; }

    public PessoaJuridica(string endereco, string telefone, string razaoSocial, string nomeFantasia, int cnpj, DateTime dataAbertura) : base(endereco, telefone)
    {
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        Cnpj = cnpj;
        DataAbertura = dataAbertura;
    }
}
