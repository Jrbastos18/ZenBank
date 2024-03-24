using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenBank.Models;
public class Cliente
{
    private int Id { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public Cliente(string endereco, string telefone)
    {
        Endereco = endereco;
        Telefone = telefone;
    }
}
