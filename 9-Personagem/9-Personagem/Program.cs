namespace _9_Personagem
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
            Console.Write("Intelecto: ");
            int intelecto = int.Parse(Console.ReadLine());

            Personagem p = new Personagem(nomePersonagem,hp,forca,intelecto);
            Console.WriteLine($"Personagem '{p.Nome}' criado na posição (0,0) com os seguintes atributos:");
            p.MostrarAtributos();

            while (true)
            {
                Console.WriteLine("\n Digite um comando (mover,atacar,inventario,pegar,largar,status,sair): ");
                string comando = Console.ReadLine().ToLower();

                if (comando == "sair") break;

                switch (comando)
                {
                    case "mover":
                        Console.Write("Digite a direção (1-frente,2-trás,3-direita,4-esquerda):");
                        int direcao = int.Parse(Console.ReadLine());
                        p.Mover(direcao);
                        break;
                    case "atacar":
                        Console.WriteLine("Digite um valor para o dano entre 0 e 10: ");
                        double dano = double.Parse(Console.ReadLine());
                        p.atacar(dano);
                        break;
                    case "inventario":
                        Console.WriteLine("Inventario: ");
                        p.MostrarIventario();
                        break;
                    case "pegar":
                        Console.WriteLine("Digite o nome do item que deseja pegar: ");
                        string item = Console.ReadLine();
                        p.AdicionarItem(item);
                        break;
                    case "largar":
                        Console.WriteLine("Digite o nome do item que deseja largar: ");
                        p.MostrarIventario();
                        string item_remover = Console.ReadLine();
                        p.RemoverItem(item_remover);
                        break;
                    case "status":
                        Console.WriteLine("Atributos");
                        p.MostrarAtributos();
                        break;
                }
            }
        }
    }
}
