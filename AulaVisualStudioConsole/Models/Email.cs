using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Email
    {
        public Email() { }

        public bool? EnviarEmail { get; set; }


        public void AceitaEnviarEmail()
        {
            if (EnviarEmail.HasValue && EnviarEmail.Value)
            {
                Console.WriteLine("O usuário optou por receber email");
            }
            else
            {
                Console.WriteLine("O usuário não respondeu ou optou por não receber email");
            }
        }
    }
}
