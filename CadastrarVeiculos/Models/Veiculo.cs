using System.Text;

namespace CadastrarVeiculos.Models
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Renavam { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string? FotoPath { get; set; } // Caminho para a imagem 
    }

    public static class VeiculoRepository
    {
        private static readonly string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data");
        private static readonly string filePath = Path.Combine(directoryPath, "veiculos.txt");

        // Executado automaticamente ao carregar o repositório
        static VeiculoRepository()
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
        }

        public static List<Veiculo> Listar()
        {
            if (!File.Exists(filePath))
                return new List<Veiculo>();

            var linhas = File.ReadAllLines(filePath);
            return linhas.Select(linha =>
            {
                var dados = linha.Split(';');
                return new Veiculo
                {
                    Nome = dados[0],
                    Modelo = dados[1],
                    Marca = dados[2],
                    Renavam = dados[3],
                    AnoFabricacao = int.Parse(dados[4]),
                    AnoModelo = int.Parse(dados[5]),
                    FotoPath = string.IsNullOrWhiteSpace(dados[6]) ? null : dados[6]
                };
            }).ToList();
        }

        public static void Adicionar(Veiculo v)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            var linha = $"{v.Nome};{v.Modelo};{v.Marca};{v.Renavam};{v.AnoFabricacao};{v.AnoModelo};{v.FotoPath}";
            File.AppendAllLines(filePath, new[] { linha }, Encoding.UTF8);
        }

        public static Veiculo? BuscarPorRenavam(string renavam)
        {
            return Listar().FirstOrDefault(v => v.Renavam == renavam);
        }

        public static void Atualizar(Veiculo atualizado)
        {
            var lista = Listar();
            var index = lista.FindIndex(v => v.Renavam == atualizado.Renavam);
            if (index >= 0)
            {
                lista[index] = atualizado;
                SalvarTodos(lista);
            }
        }

        public static void SalvarTodos(List<Veiculo> veiculos)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            var linhas = veiculos.Select(v =>
                $"{v.Nome};{v.Modelo};{v.Marca};{v.Renavam};{v.AnoFabricacao};{v.AnoModelo};{v.FotoPath}");
            File.WriteAllLines(filePath, linhas, Encoding.UTF8);
        }

        public static void Excluir(string renavam)
        {
            var lista = Listar();
            var item = lista.FirstOrDefault(v => v.Renavam == renavam);
            if (item != null)
            {
                lista.Remove(item);
                SalvarTodos(lista);
            }
        }

    }
}