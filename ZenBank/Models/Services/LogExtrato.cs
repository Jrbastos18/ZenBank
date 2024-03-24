using ZenBank.Models.Enums;

namespace ZenBank.Models.Services;
public class LogExtrato
{
    private double Valor { get; set; }
    private DateTime Data { get; set; }
    private double Saldo { get; set; }
    public TipoTransacao Tipo{ get; set; }

    public LogExtrato(double valor, DateTime data, double saldo, TipoTransacao tipo)
    {
        Valor = valor;
        Data = data;
        Saldo = saldo;
        Tipo = tipo;
    }

    public override string ToString()
    {
        return "\n"
            + Tipo
            + ": "
            + Valor.ToString("C2")
            + ", Data: "
            + Data.ToString("dd/MM/yyyy hh:mm:ss")
            + ", Saldo após transação: "
            + Saldo.ToString("C2");
    }
}
