using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personagem
{
    internal class Personagem
    {
        public string Nome;
        public int HP;
        public int Forca;
        public int Agilidade;
        public int Int;
        public int x = 0, y = 0;
        private List<string> inventario;
        private static Random random = new Random();

        public Personagem(string nome, int hp,int forca, int agilidade, int intelecto) {
            Nome = nome;
            HP = hp;
            Forca = forca;
            Agilidade = agilidade;
            Int = intelecto;
            x = 0;
            y = 0;
            inventario = new List<string>();
        }

        public void Mover(string direcao) {
            switch (direcao.ToLower()) {
                case "cima": // cima
                    y += 1;
                    break;
                case "direita": // direita
                    x += 1;
                    break;
                case "baixo": // baixo
                    y-=1; 
                    break;
                case "esquerda": // esquerda
                    x-=1;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    return;
            }
            Console.WriteLine($"Nova posição: ({x},{y})");
        }
        public void AdicionarItem(string item)
        {
            inventario.Add(item);
            Console.WriteLine($"{item} foi adicionado ao inventário.");
        }

        public void RemoverItem(string item)
        {
            if(inventario.Contains(item))
            {
                inventario.Remove(item);
                Console.WriteLine($"{item} foi removido do inventário.");
            }
            else
            {
                Console.WriteLine("${item} não encontrado no inventário ");
            }
        }
        public void MostrarIventario() {
            Console.WriteLine("\n Inventário:");
            if (inventario.Count == 0) {
                Console.WriteLine("Inventário vazio");
            } else
            {
                foreach (var item in inventario)
                {
                    Console.WriteLine($"-{item}");
                }
            }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"\n Atributos de {Nome}:");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Força: {Forca}");
            Console.WriteLine($"Agilidade: {Agilidade}");
            Console.WriteLine($"Intelecto: {Int}");
        }
        public void Atacar() {
            double danoSorte = random.NextDouble() * 10;
            double dano = Forca * (danoSorte / 10);
            Console.WriteLine($"{Nome} realizou um ataque causando {dano} de dano; [Multiplicador: {danoSorte}");
        }
    }
}
