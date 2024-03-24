using ZenBank.Models;

namespace ZenBank;

internal class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta(new Cliente("Rua 1", "99999999"), 001, 0000001, 500);

        Menu menu = new Menu();

        menu.MenuPrincipal();
        
    }
}
