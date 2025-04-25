namespace _10_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando encapsulamento");
            Produto p1 = new Produto();
            p1.Quantidade = 10;
            p1.Codigo = 154;
            p1.Nome = "Coca-Cola";
            p1.Valor = 10.29;
            p1.Exibir();

        }
    }
}