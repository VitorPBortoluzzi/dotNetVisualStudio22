using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrimeiroProjeto.Models;

namespace PrimeiroProjeto.Pages.Usuarios
{
    public class CriarModel : PageModel
    {
        public Usuario usuario { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid)
            {
                return Page();
            }        
            else
            {
                //Vou fazer o armazenamento destes dados dentro do seu arquivo texto
                using (var writer = new StreamWriter("usuarios.txt", true))
                {
                    writer.WriteLine(usuario.Id + ";" + usuario.Nome + ";" + usuario.Senha + ";" + usuario.Email);
                    return RedirectToPage("/Usuarios/Index");
                }
            }
        }
    }
}
