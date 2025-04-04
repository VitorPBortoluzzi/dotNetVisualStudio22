namespace Personagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do seu personagem: ");
            string nomePersonagem = Console.ReadLine();

            Console.WriteLine("\n Defina os atributos do seu personagem: ");
            Console.Write("HP: ");
            int hp = int.Parse(Console.ReadLine());
            Console.Write("Força: ");
            int forca = int.Parse(Console.ReadLine());
            Console.Write("Agilidade: ");
            int agilidade = int.Parse(Console.ReadLine());
            Console.Write("Intelecto: ");
            int intelecto = int.Parse(Console.ReadLine());

            Personagem p = new Personagem(nomePersonagem, hp, forca, agilidade, intelecto);
            Console.WriteLine($"Personagem '{p.Nome}' criado na posição (0,0) com os seguintes atributos:");
            p.MostrarAtributos();

            while (true)
            {
                Console.WriteLine("\n Digite um comando (mover, pegar, largar, inventario, status, sair): ");
                string comando = Console.ReadLine().ToLower();

                if (comando == "sair") break;

                switch (comando)
                {
                    case "mover":
                        Console.WriteLine("Digite a direção (cim,baixo,esquerda,direita): ");
                        string direcao = Console.ReadLine();
                        p.Mover(direcao);
                        break;
                    case "pegar":
                        Console.WriteLine("Digite o nome do item para pegar: ");
                        string itemPegar = Console.ReadLine();
                        p.AdicionarItem(itemPegar);
                        break;
                    case "largar":
                        Console.WriteLine("Digite o nome do item para largar: ");
                        string itemLargar = Console.ReadLine();
                        p.RemoverItem(itemLargar);
                        break;
                    case "inventario":
                        p.MostrarIventario();
                        break;
                    case "status":
                        p.MostrarAtributos();
                        break;
                    case "atacar":
                        p.Atacar();
                        break;
                    default:
                        Console.WriteLine("Comando inválido");
                        break;
                }
            }
        }
    }
}