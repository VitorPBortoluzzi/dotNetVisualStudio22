using CadastrarVeiculos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastrarVeiculos.Pages.Veiculos
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Veiculo Veiculo { get; set; }

        [BindProperty]
        public IFormFile? FotoUpload { get; set; }

        public IActionResult OnGet(string renavam)
        {
            Veiculo = VeiculoRepository.BuscarPorRenavam(renavam);

            if (Veiculo == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Garante a existência da pasta
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

            VeiculoRepository.Atualizar(Veiculo);
            return RedirectToPage("Index");
        }
    }
}
