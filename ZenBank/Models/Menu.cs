namespace ZenBank.Models;
public class Menu
{
    public void MenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("Menu Principal");
        Console.WriteLine("---------------");
        Console.WriteLine("\n1. Cadastro");
        Console.WriteLine("2. Sair");
        Console.WriteLine();
        Console.Write("Entre com uma opção (1 - 2): ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                MenuCadastro();
                break;
            case 2:
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    public void MenuCadastro()
    {
        Console.Clear();
        Console.WriteLine("Cadastro");
        Console.WriteLine("------------");
        Console.WriteLine("\n1. Pessoa Física");
        Console.WriteLine("2. Pessoa Jurídica");
        Console.WriteLine("3. Voltar ao Menu Principal");
        Console.WriteLine("4. Sair");
        Console.WriteLine();
        Console.Write("Entre com uma opção (1 - 4): ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("Nome completo: ");
                string nome = Console.ReadLine();
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                break; 
            case 2:
                Console.Write("Razão Social: ");
                string razaoSocial = Console.ReadLine();
                Console.Write("Nome Fantasia: ");
                string nomeFantasia = Console.ReadLine();
                Console.Write("CNPJ: ");
                string cnpj = Console.ReadLine();
                Console.Write("Data de abertura: ");
                DateTime dataAbertura = DateTime.Parse(Console.ReadLine());
                break;
            case 3:
                MenuPrincipal();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
