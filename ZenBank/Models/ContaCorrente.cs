namespace ZenBank.Models;
class ContaCorrente : Conta
{
    public ContaCorrente(Cliente titular, int agencia, double saldo, double limiteSaque) : base(titular, agencia, saldo, limiteSaque)
    {
    }

    public override string ToString()
    {
        return "\nAgencia: " + Agencia
            + "\nConta corrente: " + NumeroDaConta
            + "\nSaldo: " + Saldo.ToString("C2")
            + "\nLimite de saque: " + LimiteSaque.ToString("C2")
            + "\nData de abertura: " + DataAbertura.ToString("dd/MM/yyyy HH:mm:ss")
            + "\n\nTitular: " + Titular;
    }
}
