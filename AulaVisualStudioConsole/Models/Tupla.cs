using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Tupla
    {

        public Tupla() 
        { 
        }

        public void Criando() 
        {
            (int, string, string) dupla = (1, "Amauri", "Dall Oglio"); //para não criar classe

            Console.WriteLine(dupla);

        }
    }
}
