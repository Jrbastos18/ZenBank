using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenBank.Models.Services;

namespace ZenBank.Models;
class ContaCorrente : Conta
{
    public ContaCorrente(int id, Cliente titular, int agencia, int numeroDaConta, double saldo, DateTime dataAbertura, double limiteSaque) : base(id, titular, agencia, numeroDaConta, saldo, dataAbertura, limiteSaque)
    {
    }
}
