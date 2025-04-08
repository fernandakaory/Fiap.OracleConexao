using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.OracleConexao.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; } //o "?"significa que ele aceita nulo

        public Cliente() { }
    }
}
