using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using Web_Car.Models;
using Web_Car.Services;

namespace Web_Car.Pages.Veiculos
{
    public class EditModel : PageModel
    {
        private readonly VeiculoService _service = new VeiculoService();

        [BindProperty]
        public Veiculo Veiculo { get; set; }

        [BindProperty]
        public IFormFile Foto { get; set; }

        public IActionResult OnGet(int id)
        {
            Veiculo = _service.GetById(id);
            if (Veiculo == null)
            {
                return RedirectToPage("Index");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var veiculoExistente = _service.GetById(Veiculo.Id);
            if (veiculoExistente == null)
            {
                return RedirectToPage("Index");
            }

            if (Foto != null)
            {
                // Apaga a foto antiga, se existir
                if (!string.IsNullOrEmpty(veiculoExistente.FotoPath))
                {
                    var oldPath = Path.Combine("wwwroot", veiculoExistente.FotoPath.TrimStart('/'));
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

                var fileName = Path.GetFileName(Foto.FileName);
                var filePath = Path.Combine("wwwroot/uploads", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Foto.CopyToAsync(stream);
                }
                Veiculo.FotoPath = "/uploads/" + fileName;
            }
            else
            {
                // Mantém a foto atual
                Veiculo.FotoPath = veiculoExistente.FotoPath;
            }

            _service.Update(Veiculo);
            return RedirectToPage("Index");
        }
    }
}
