using CadastrarVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastrarVeiculos.Pages.Veiculos
{
    public class IndexModel : PageModel
    {
        public List<Veiculo> Veiculos { get; set; } = new();

        public void OnGet()
        {
            Veiculos = VeiculoRepository.Listar();
        }
    }
}