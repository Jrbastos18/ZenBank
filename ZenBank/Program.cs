using ZenBank.Models;

namespace ZenBank;

internal class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta(new Cliente("Rua 1", "99999999"), 001, 0000001, 500);

        Menu menu = new Menu();

        menu.MenuPrincipal();

        Console.WriteLine("Quanto deseja sacar?");
        double valor = double.Parse(Console.ReadLine());

        conta.Sacar(valor);

        Console.WriteLine("\nQuanto deseja depositar?");
        valor = double.Parse(Console.ReadLine());
        conta.Depositar(valor);

        Console.WriteLine("\nQuanto deseja sacar?");
        valor = double.Parse(Console.ReadLine());
        conta.Sacar(valor);

        Console.WriteLine("\nQuanto deseja depositar?");
        valor = double.Parse(Console.ReadLine());
        conta.Depositar(valor);

        conta.Extrato();

    }
}
