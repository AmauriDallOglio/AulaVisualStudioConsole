using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Pessoa
    {
        public Pessoa() { }

        public Pessoa(string nome)   //construtor por herança
        {
            Nome = nome; //obrigando a passar um nome
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()  //virtual = public override void Apresentar() ////Sobrescreve o metodo da herança polimorfismo
        {
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade} anos!");
        }
    }
}
