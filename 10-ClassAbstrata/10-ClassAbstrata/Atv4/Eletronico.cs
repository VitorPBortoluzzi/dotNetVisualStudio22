using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv4
{
    internal class Eletronico : Produto
    {
        private const decimal valorDesconto = 0.125m;

        public string Descricao;
        public override void CalcularDesconto()
        {
            Console.WriteLine($"Produto Eletronico: {Descricao}");
            Console.WriteLine($"Valor: {Preco}, desconto de 12%({Preco * valorDesconto}), preço final: {Preco -= (Preco * valorDesconto)}");
        }
    }
}
