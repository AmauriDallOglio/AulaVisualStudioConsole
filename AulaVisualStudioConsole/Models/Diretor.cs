using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Diretor : Professor
    {
        public Diretor() 
        {
        }    

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} tenho {Idade} anos e sou o diretor!");
        }

    }
}
