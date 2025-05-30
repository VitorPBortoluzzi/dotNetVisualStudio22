using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Car.Models;

namespace Web_Car.Pages.Veiculos
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Veiculo v { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                using (var writer = new StreamWriter("veiculos.txt", true))
                {
                    writer.WriteLine(v.Id + ";" + v.Name + ";" + v.Modelo + ";" + v.Marca + ";" + v.Renavam + ";" + v.AnoFabric + ";" + v.AnoModelo);
                }
                return RedirectToPage("/Veiculos/Index");
            }
        }
    }
}
