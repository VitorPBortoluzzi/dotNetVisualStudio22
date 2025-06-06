using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Car.Models;
using Web_car.Services;

namespace Web_Car.Pages.Veiculos
{
    public class CreateModel : PageModel
    {
        [BindProperty] public Veiculo Veiculo { get; set; }
        [BindProperty] public IFormFile? Foto { get; set; }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Foto != null)
            {
                var fileName = Path.GetFileName(Foto.FileName);
                var filePath = Path.Combine("wwwroot/uploads", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await Foto.CopyToAsync(stream);
                }
                
                Veiculo.FotoPath = "/uploads/" + fileName;
            }

            new VeiculoService().Add(Veiculo);
            return RedirectToPage("Index");
        }
    }
}
