using CadastrarVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastrarVeiculos.Pages.Veiculos
{
    public class DeletModel : PageModel
    {
        [BindProperty]
        public Veiculo? Veiculo { get; set; }

        public IActionResult OnGet(string renavam)
        {
            Veiculo = VeiculoRepository.BuscarPorRenavam(renavam);
            if (Veiculo == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (Veiculo != null)
            {
                VeiculoRepository.Excluir(Veiculo.Renavam);
            }

            return RedirectToPage("Index");
        }
    }
}
