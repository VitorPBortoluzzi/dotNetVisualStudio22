using Web_Car.Models;
using System.Text;

namespace Web_car.Services
{
    public class VeiculoService
    {
        private readonly string filePath = "veiculos.txt";

        public List<Veiculo> GetAll()
        {
            if (!File.Exists(filePath)) return new List<Veiculo>();

            return File.ReadAllLines(filePath)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(FromCsv)
                .ToList();
        }

        public Veiculo? GetById(int id)
        {
            return GetAll().FirstOrDefault(v => v.Id == id);
        }

        public void Add(Veiculo veiculo)
        {
            var veiculos = GetAll();
            veiculo.Id = veiculos.Any() ? veiculos.Max(v => v.Id) + 1 : 1;
            veiculos.Add(veiculo);
            SaveAll(veiculos);
        }

        public void Update(Veiculo veiculo)
        {
            var veiculos = GetAll();
            var index = veiculos.FindIndex(v => v.Id == veiculo.Id);
            if (index >= 0)
            {
                veiculos[index] = veiculo;
                SaveAll(veiculos);
            }
        }

        public void Delete(int id)
        {
            var veiculos = GetAll();
            var veiculo = veiculos.FirstOrDefault(v => v.Id == id);
            if (veiculo != null)
            {
                if (!string.IsNullOrEmpty(veiculo.FotoPath))
                {
                    var path = Path.Combine("wwwroot", veiculo.FotoPath.TrimStart('/'));
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }

                veiculos.Remove(veiculo);
                SaveAll(veiculos);
            }
        }

        private void SaveAll(List<Veiculo> veiculos)
        {
            File.WriteAllLines(filePath, veiculos.Select(ToCsv));
        }

        private Veiculo FromCsv(string line)
        {
            var parts = line.Split(';');
            return new Veiculo
            {
                Id = int.Parse(parts[0]),
                Nome = parts[1],
                Modelo = parts[2],
                Marca = parts[3],
                Renavam = parts[4],
                AnoFabricacao = int.Parse(parts[5]),
                AnoModelo = int.Parse(parts[6]),
                FotoPath = parts.Length > 7 ? parts[7] : null
            };
        }

        private string ToCsv(Veiculo v)
        {
            return string.Join(";", v.Id, v.Nome, v.Modelo, v.Marca, v.Renavam, v.AnoFabricacao, v.AnoModelo, v.FotoPath);
        }
    }
}