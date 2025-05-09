using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAplication.Pages
{
    public class ProdutoModel : PageModel
    {
        public List<Produto> Produtos { get; set; }
        public void OnGet()
        {
            Produtos = new List<Produto>
            {
            new Produto { Descricao = "Coca Cola", Preco = 8.99m },
            new Produto { Descricao = "Pepsi Cola", Preco = 6.99m },
            new Produto { Descricao = "Feijao", Preco = 3.49m },
            new Produto { Descricao = "Arroz", Preco = 4.37m },
            new Produto { Descricao = "Carne Moida", Preco = 23.50m }
            };
        }
    }
    public class Produto { 
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
