using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_Car.Models;

namespace Web_Car.Pages.Veiculos
{
    public class IndexModel : PageModel
    {
        public List<Veiculo> Veiculos { get; set; }
        public void OnGet()
        {
            Veiculos = new List<Veiculo>();
            if (System.IO.File.Exists("veiculos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("veiculos.txt");
                foreach(var linha in linhas)
                {
                    string[] campos = linha.Split(';');
                    var v = new Veiculo();
                    v.Id = int.Parse(campos[0]);
                    v.Name = campos[1];
                    v.Modelo = campos[2];
                    v.Marca = campos[3];
                    v.Renavam = campos[4];
                    v.AnoFabric = campos[5];
                    v.AnoModelo = campos[6];
                }
            }
        }
    }
}
