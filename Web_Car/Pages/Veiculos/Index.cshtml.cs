using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Web_Car.Models;
using Web_Car.Services;

namespace Web_Car.Pages.Veiculos
{
    public class IndexModel : PageModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public void OnGet()
        {
            var service = new VeiculoService();
            Veiculos = service.GetAll();
        }
    }
}