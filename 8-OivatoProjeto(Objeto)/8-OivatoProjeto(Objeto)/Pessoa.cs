using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OivatoProjeto_Objeto_
{
    internal class Pessoa
    {
        public string nome;
        public string email;
        public int idade;
    }
    internal class Carro {
        public string marca;
        public string modelo;
        public int anoFabricado;
    }
    internal class Livro {
        public string titulo = "Livro";
        public string autor = "Autor";
        public int anoPublic = 2025;

        public void Emprestar() {
            Console.WriteLine("Livro: "+titulo + "emprestado");
        }

    }
    internal class Jogo {
        public string titulo;
        public string genero;
        public string plataforma;
        public int anoLancamento;
    }
}
