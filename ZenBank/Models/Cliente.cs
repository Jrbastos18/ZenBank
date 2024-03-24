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
    public DateTime DataCadastro { get; set; }

    public Cliente(string endereco, string telefone)
    {
        Random randId = new Random();
        Id = randId.Next();
        Endereco = endereco;
        Telefone = telefone;
        DataCadastro = DateTime.Now;
    }
}
