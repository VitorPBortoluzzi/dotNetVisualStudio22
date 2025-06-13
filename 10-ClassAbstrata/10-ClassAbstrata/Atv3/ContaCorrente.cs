using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv3
{
    internal class ContaCorrente : ContaBancaria
    {
        private const decimal TaxaSque = 2.50m;

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} na conta Corrente. Saldo atual: R${Saldo}");
        }

        public override void Sacar(decimal valor)
        {
            decimal totalSaque = valor + TaxaSque;

            if (Saldo >= totalSaque)
            {
                Saldo -= totalSaque;
                Console.WriteLine($"Saque de R${valor} (+ R${TaxaSque} taxa) realizado. Saldo atual: {Saldo}");
            }
            else Console.WriteLine("Saldo insuficiente na Conta Corrente");
        }
    }
}
