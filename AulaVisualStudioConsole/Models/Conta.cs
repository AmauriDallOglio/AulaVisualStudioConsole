using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public abstract class Conta //Classe modelo para ser utilizada por outra classe
    {
        protected Conta() { }

        protected decimal saldo;

        public abstract void Creditar(decimal valor); //assinatura do método

        public void ExibirSaldo()
        {
            Console.WriteLine($"Meu saldo é: {saldo}");
        }
    }
}
