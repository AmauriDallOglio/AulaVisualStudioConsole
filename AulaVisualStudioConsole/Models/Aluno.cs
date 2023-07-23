using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Aluno : Pessoa
    {
 
        public Aluno() { }

        public Aluno(string nome) : base(nome) //construtor por herança de pessoa
        {

        }

        public bool Ativo { get; set; }

        public override void Apresentar() ////Sobrescreve o metodo da herança polimorfismo
        {
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade} anos e sou um aluno!");
        }

    }
}
