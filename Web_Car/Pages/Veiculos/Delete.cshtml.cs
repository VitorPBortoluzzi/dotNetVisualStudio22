using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Car.Models;
using Web_Car.Services;

namespace Web_Car.Pages.Veiculos
{
    public class DeleteModel : PageModel
    {
        private readonly VeiculoService _service = new VeiculoService();

        [BindProperty]
        public Veiculo Veiculo { get; set; }

        public IActionResult OnGet(int id)
        {
            Veiculo = _service.GetById(id);
            if (Veiculo == null)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            _service.Delete(Veiculo.Id);
            return RedirectToPage("Index");
        }
    }
}
