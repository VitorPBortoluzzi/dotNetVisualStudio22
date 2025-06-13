using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv4
{
    internal class Livro : Produto
    {
        private const decimal valorDesconto = 0.05m;

        public string Descricao;

        public override void CalcularDesconto()
        {
            Console.WriteLine($"Livro: {Descricao}");
            Console.WriteLine($"Valor: {Preco}, desconto de 5%({Preco * valorDesconto}), preço final: {Preco -= (Preco * valorDesconto)}");
        }
    }
}
