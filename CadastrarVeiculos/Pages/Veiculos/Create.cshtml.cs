using CadastrarVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastrarVeiculos.Pages.Veiculos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Veiculo Veiculo { get; set; }

        [BindProperty]
        public IFormFile? FotoUpload { get; set; }

        public IActionResult OnGet() => Page();

        public async Task<IActionResult> OnPostAsync()
        {
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data"));

            if (!ModelState.IsValid)
                return Page();

            if (FotoUpload != null)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(FotoUpload.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                using var stream = new FileStream(filePath, FileMode.Create);
                await FotoUpload.CopyToAsync(stream);

                Veiculo.FotoPath = "/uploads/" + fileName;
            }

            VeiculoRepository.Adicionar(Veiculo);
            return RedirectToPage("Index");
        }
    }
}