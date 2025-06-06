namespace Web_Car.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Renavam { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string? FotoPath { get; set; }
    }
}
