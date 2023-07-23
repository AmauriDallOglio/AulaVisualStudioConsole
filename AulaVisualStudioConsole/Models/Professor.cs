using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Professor : Pessoa   //sealed não pode ter mais classes filhas
    {
        public Professor() { }

        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }

        public override void Apresentar()   //sealed não pode ter mais classes filhas
        {
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade} anos e sou um professor e ganho {Salario}!");
        }
    }
}
