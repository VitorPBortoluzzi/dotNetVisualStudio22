using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
4 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto". Crie classes derivadas para diferentes tipos de produtos, 
como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto" de acordo com as regras específicas de desconto para cada tipo de produto.
Livro – 5% de desconto
Eletrônico - 12.5% de desconto
*/

namespace _10_ClassAbstrata.Atv4
{
    abstract class Produto
    {
        public string Nome;
        public decimal Preco;

        public abstract void CalcularDesconto();
    }
}
