using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial) 
        {
            NumeroConta= numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo; //encapsulamento

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado no valor de {valor} saldo atual é de {saldo}");
            }
            else
            {
                Console.WriteLine($"Valor {valor} é maior que saldo {saldo} ");
            }
        }
    }
}
