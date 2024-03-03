using ZenBank.Models;

namespace ZenBank;

internal class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta(123, new Cliente(), 001, 0000001, 500.00, DateTime.Now, 1000.00);

        conta.Sacar(300.00);

    }
}
