using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Venda
    {
        public Venda() { }
        public Venda(int id, string produto, decimal preco) 
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
    }
}
