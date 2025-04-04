using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_Projeto9
{
    internal class Livro
    {
        //// 2- Crie uma classe Livro que represente os dados básicos de um livro,
        // além destes, criar um atributo do tipo boolean chamado emprestado.
        // Crie métodos emprestar e devolver que altera o atributo emprestado
        // Crie um método construtor que receba todos os valores por parâmetros,
        // exceto o atributo emprestado que obrigatoriamente deve ser inicializado como false
        // Faça a leitura pelo teclado dos atributos para instanciar dois livros

        public string titulo;
        public string autor;
        public string genero;
        public int anoPublicacao;
        public bool emprestado;

        public Livro(string titulo, string autor, string genero, int anoPublicacao, bool emprestado = false)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.anoPublicacao = anoPublicacao;
            this.emprestado = emprestado;
        }

        public void emprestar()
        {
            if (emprestado != true)
            {
                emprestado = true;
                Console.WriteLine("O livro está emprestado");
            }
            else
            {
                Console.WriteLine("o livro já está emprestado!!!");
            }
        }
        public void devolver()
        {
            if (emprestado != false)
            {
                emprestado = false;
                Console.WriteLine("O livro foi devolvido");
            }
            else
            {
                Console.WriteLine("o livro já foi devolvido!!!");
            }
        }
}
