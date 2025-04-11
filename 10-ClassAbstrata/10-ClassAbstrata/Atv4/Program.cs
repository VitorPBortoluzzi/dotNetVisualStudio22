namespace _10_ClassAbstrata.Atv4
{
    /*
4 - Crie uma classe abstrata "Produto" com propriedades para "Nome", "Preço" e um método abstrato "CalcularDesconto". Crie classes derivadas para diferentes tipos de produtos, 
como "Livro" e "Eletrônico", que implementam o método "CalcularDesconto" de acordo com as regras específicas de desconto para cada tipo de produto.
Livro – 5% de desconto
Eletrônico - 12.5% de desconto
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro()
            {
                Nome = "O pequeno Principe",
                Descricao = "História do pequeno Principe",
                Preco = 200.0m
            };

            Eletronico eletronico = new Eletronico()
            {
                Nome = "Celular",
                Descricao = "Galaxy AS05",
                Preco = 1500.00m
            };

            livro.CalcularDesconto();
            eletronico.CalcularDesconto();
        }
    }
}
