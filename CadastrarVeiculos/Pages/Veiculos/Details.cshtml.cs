using CadastrarVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastrarVeiculos.Pages.Veiculos
{
    public class DetailsModel : PageModel
    {
        public Veiculo? Veiculo { get; set; }

        public IActionResult OnGet(string renavam)
        {
            Veiculo = VeiculoRepository.BuscarPorRenavam(renavam);

            if (Veiculo == null)
                return NotFound();

            return Page();
        }
    }
}