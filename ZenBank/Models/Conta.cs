using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBank.Models.Enums;
using ZenBank.Models.Services;

namespace ZenBank.Models;
public class Conta
{
    //Propriedades da classe conta
    public int Id { get; set; }
    public Cliente Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public DateTime DataAbertura { get; set; }
    public int TotalSaques { get; set; }
    public int TotalDepositos { get; set; }
    public double LimiteSaque { get; set; }
    public List<LogExtrato> LogExtratos { get; set; } = new List<LogExtrato>();

    public Conta(int id, Cliente titular, int agencia, int numeroDaConta, double saldo, DateTime dataAbertura, double limiteSaque)
    {
        Id = id;
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        DataAbertura = dataAbertura;
        LimiteSaque = limiteSaque;
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo indisponível");
        }
        else if (valor <= 0)
        {
            Console.WriteLine("Não é possível sacar valor negativo ou que seja 0!");
        }
        else
        {
            if (valor > LimiteSaque)
            {
                Console.WriteLine($"Não é possível sacar além do seu limite! Seu limite atual para saque é: {LimiteSaque.ToString("C2")}");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"{valor.ToString("C2")} sacado com sucesso!");
                Console.WriteLine("Seu novo saldo é de: " + Saldo.ToString("C2"));
                LogExtratos.Add(new LogExtrato(valor, DateTime.Now, Saldo, TipoTransacao.Saque));
            }
        }
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        LogExtratos.Add(new LogExtrato(valor, DateTime.Now, Saldo, TipoTransacao.Deposito));
        Console.WriteLine($"Depósito efetuado com sucesso! Seu novo saldo é de: {Saldo.ToString("C2")}");
    }

    public void Extrato()
    {
        Console.WriteLine("Escolha uma opção para extrato:");
        Console.WriteLine("1 ----------------- Saques");
        Console.WriteLine("2 ----------------- Depositos");
        Console.WriteLine("3 ----------------- Ambos ");
        int opc = int.Parse(Console.ReadLine());

        if (opc < 1 || opc > 3)
        {
            Console.WriteLine("Opção inválida!");
        }
        else if (opc == 1)
        {
            var saques = LogExtratos.Select(x => x).Where(y => y.Tipo == TipoTransacao.Saque).ToList();
            foreach (var saque in saques)
            {
                Console.WriteLine(saque);
            }
        }
        else if (opc == 2)
        {
            var depositos = LogExtratos.Select(x => x).Where(y => y.Tipo == TipoTransacao.Deposito).ToList();
            foreach (var deposito in depositos)
            {
                Console.WriteLine(deposito);
            }
        }
        else
        {
            foreach (var extrato in LogExtratos)
            {
                Console.WriteLine(extrato);
            }
        }
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine("O seu saldo atual é: ", Saldo.ToString("C2"));
    }

    public void Pagamento(double valor)
    {
    }

}
