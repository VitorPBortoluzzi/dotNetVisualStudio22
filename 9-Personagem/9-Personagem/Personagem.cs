using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Personagem
{
    internal class Personagem
    {
        public string Nome;
        public int X = 0, Y = 0;
        public List<string> Inventario;
        public int HP;
        public int Forca;
        public int Inte;

        public Personagem(string nome,int hp, int forca, int inte)
        {
            Nome = nome;
            HP = hp;
            Forca = forca;
            Inte = inte;
            X = 0;
            Y = 0;
            Inventario = new List<string>();
        }

        public void Mover(int direcao)
        {
            switch (direcao)
            {
                case 1: // frente
                    Y += 1;
                    break;
                case 2: // tras
                    Y -= 1;
                    break;
                case 3: // direita
                    X+= 1;
                    break;
                case 4: // esquerda
                    X -= 1;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    return;
            }
            Console.WriteLine($"Nova posição: ({X},{Y})");
        }

        public void atacar(double dano) { 
            if (dano < 0 || dano > 10)
            {
                Console.WriteLine("Dano inválido! Fora da escala de 0 a 10");
                return;
            }
            Console.WriteLine($"{Nome} atacou causando {dano}/10 de dano.");
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"\n Atributos de {Nome}:");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Intelecto: {Inte}");
        }

        public void MostrarIventario()
        {
            Console.WriteLine("\n Inventário:");
            if (Inventario.Count == 0)
            {
                Console.WriteLine("Inventário vazio");
            }
            else
            {
                foreach (var item in Inventario)
                {
                    Console.WriteLine($"-{item}");
                }
            }
        }

        public void AdicionarItem(string item)
        {
            Inventario.Add(item);
            Console.WriteLine($"{item} foi adicionado ao inventário.");
        }

        public void RemoverItem(string item)
        {
            if (Inventario.Contains(item))
            {
                Inventario.Remove(item);
                Console.WriteLine($"{item} foi removido do inventário.");
            }
            else
            {
                Console.WriteLine("${item} não encontrado no inventário ");
            }
        }
    }
}
