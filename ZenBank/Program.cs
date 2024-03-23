using ZenBank.Models;

namespace ZenBank;

internal class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta(123, new Cliente(), 001, 0000001, 500, DateTime.Now, 200);


        Console.WriteLine("Quanto deseja sacar?");
        double valor = double.Parse(Console.ReadLine());

        conta.Sacar(valor);

        Console.WriteLine("\nQuanto deseja depositar?");
        valor = double.Parse(Console.ReadLine());
        conta.Depositar(valor);

        Console.WriteLine("Quanto deseja sacar?");
        valor = double.Parse(Console.ReadLine());
        conta.Sacar(valor);

        Console.WriteLine("\nQuanto deseja depositar?");
        valor = double.Parse(Console.ReadLine());
        conta.Depositar(valor);

        conta.Extrato();

    }
}
