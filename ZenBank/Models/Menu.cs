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
        Console.WriteLine("Menu de Cadastro");
        Console.WriteLine("----------------");
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
                Console.Write("Endereço: ");
                string endereco = Console.ReadLine();
                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Cliente pf = new PessoaFisica(nome, cpf, nascimento, endereco, telefone);
                Console.Clear();
                Console.WriteLine("Cadastro efetuado com sucesso!");
                Console.WriteLine();
                Console.WriteLine(pf);
                Console.WriteLine();
                Console.WriteLine("Deseja abrir uma conta? S/N");
                char abrirConta = char.Parse(Console.ReadLine().ToUpper());
                switch (abrirConta)
                {
                    case 'S':
                        MenuAberturaConta(pf);
                        break;
                    case 'N':
                        MenuPrincipal();
                        break;
                    default:
                        Console.Write("Opção inválida!");
                        break;
                }


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
                Console.Write("Endereço: ");
                string enderecoJuridico = Console.ReadLine();
                Console.Write("Telefone: ");
                string telefoneJuridico = Console.ReadLine();

                Cliente pj = new PessoaJuridica(razaoSocial, nomeFantasia, cnpj, dataAbertura, enderecoJuridico, telefoneJuridico);
                Console.Clear();
                Console.WriteLine("Cadastro efetuado com sucesso!");
                Console.WriteLine();
                Console.WriteLine(pj);
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

    public void MenuAberturaConta(Cliente titular)
    {
        Console.Clear();
        Console.WriteLine("Menu de Abertura de Conta");
        Console.WriteLine("--------------------------");
        Console.WriteLine("\n1. Conta Corrente");
        Console.WriteLine("2. Conta Poupança (Ainda não criado 24/03/2024)");
        Console.WriteLine("3. Voltar ao Menu Principal");
        Console.WriteLine("4. Sair");
        Console.WriteLine();
        Console.Write("Entre com uma opção (1 - 4): ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Cadastro de Conta Corrente");
                Console.WriteLine("--------------------------");
                Console.Write("\nAgencia: ");
                int ag = int.Parse(Console.ReadLine());
                Console.Write("Saldo inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());

                Conta cc = new ContaCorrente(titular, ag, saldoInicial, limiteSaque);

                Console.Clear();
                Console.WriteLine("\nConta corrente criada com sucesso!");
                Console.WriteLine();
                Console.WriteLine(cc);
                Console.WriteLine();
                MenuConta(cc);

                break;
            case 2:
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

    public void MenuConta(Conta conta)
    {
        Console.Clear();
        Console.WriteLine("Menu da Conta");
        Console.WriteLine("----------------");
        Console.WriteLine("\n1. Sacar");
        Console.WriteLine("2. Depositar");
        Console.WriteLine("3. Extrato");
        Console.WriteLine("4. Informações do cliente e conta");
        Console.WriteLine("5. Menu Principal");
        Console.WriteLine("6. Sair");
        Console.WriteLine();
        Console.Write("Entre com uma opção (1 - 5): ");
        int opcao = int.Parse(Console.ReadLine());
        double valor;
        char mc;

        switch (opcao)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Quanto deseja sacar?");
                valor = double.Parse(Console.ReadLine());
                conta.Sacar(valor, conta.LimiteSaque);
                Console.WriteLine();
                Console.WriteLine("Deseja voltar para o menu da conta (S/N)?");
                mc = char.Parse(Console.ReadLine().ToUpper());
                if (mc != 'S' && mc != 'N')
                {
                    Console.WriteLine("Opção inválida!");
                }
                else if (mc == 'S')
                {
                    MenuConta(conta);
                }
                break;
            case 2: 
                Console.Clear();
                Console.WriteLine("Quanto deseja depositar?");
                valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);
                Console.WriteLine();
                Console.WriteLine("Deseja voltar para o menu da conta (S/N)?");
                mc = char.Parse(Console.ReadLine().ToUpper());
                if (mc != 'S' && mc != 'N')
                {
                    Console.WriteLine("Opção inválida!");
                }
                else if (mc == 'S')
                {
                    MenuConta(conta);
                }
                break;
            case 3:
                Console.Clear();
                conta.Extrato();
                Console.WriteLine();
                Console.WriteLine("Deseja voltar para o menu da conta (S/N)?");
                mc = char.Parse(Console.ReadLine().ToUpper());
                if (mc != 'S' && mc != 'N')
                {
                    Console.WriteLine("Opção inválida!");
                }
                else if (mc == 'S')
                {
                    MenuConta(conta);
                }
                break;
            case 4:
                Console.Clear();
                Console.WriteLine(conta);
                Console.WriteLine();
                Console.WriteLine("Deseja voltar para o menu da conta (S/N)?");
                mc = char.Parse(Console.ReadLine().ToUpper());
                if (mc != 'S' && mc != 'N')
                {
                    Console.WriteLine("Opção inválida!");
                }
                else if (mc == 'S')
                {
                    MenuConta(conta);
                }
                break;
            case 5:
                MenuPrincipal();
                break;
            case 6:
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
