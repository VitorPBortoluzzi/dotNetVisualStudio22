using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv3
{

    /*
     3 - Crie uma classe abstrata "ContaBancaria" com propriedades para "Saldo" e métodos abstratos "Depositar" e "Sacar". Crie classes derivadas, como "ContaCorrente" e "ContaPoupanca", 
    que implementam os métodos de depósito e saque de acordo com as regras de cada tipo de conta.
*/
    abstract class ContaBancaria
    {
        public decimal Saldo;

        public abstract void Depositar(decimal valor);
        public abstract void Sacar(decimal valor);
    }
}
