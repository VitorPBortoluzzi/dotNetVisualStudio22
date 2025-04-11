using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv3
{
    internal class ContaPoupanca : ContaBancaria
    {

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} na Poupança. Saldo atual: R${Saldo}");
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado. Saldo atual: {Saldo}");
            }
            else Console.WriteLine("Saldo insuficiente na Conta Poupança");
        }
    }
}
