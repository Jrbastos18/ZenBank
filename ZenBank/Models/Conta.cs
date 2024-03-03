using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public int TotalDepositos { get; set;}
    public double LimiteConta { get; set; }

    public Conta(int id, Cliente titular, int agencia, int numeroDaConta, double saldo, DateTime dataAbertura, double limiteConta)
    {
        Id = id;
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        DataAbertura = dataAbertura;
        LimiteConta = limiteConta;
    }

    public void Sacar(double valor)
    {
        if(valor > LimiteConta)
        {
            throw new ArgumentException("Não é possível sacar além do seu limite! Tente outro valor");
        }
        else if(valor <= LimiteConta && valor > 0)
        {
            Saldo -= valor;
            Console.WriteLine($"{valor.ToString("C2")} sacado com sucesso!");
            Console.WriteLine("Seu novo saldo é de: " +  Saldo.ToString("C2"));
        }
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Extrato(DateTime dataInicial, DateTime dataFinal)
    {

    }

    public void ConsultarSaldo()
    {
        Console.WriteLine("O seu saldo atual é: ", Saldo.ToString("C2"));
    }


}
