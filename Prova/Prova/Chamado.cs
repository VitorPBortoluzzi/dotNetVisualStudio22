using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    abstract class Chamado
    {
        public string Titulo;
        public string Descricao;
        public string Status;

        public Chamado(string Titulo, string Descricao)
        {
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            Status = "Aberto";
        }

        public void Exibir()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Status Atual: {Status}");
        }
        public abstract void Executar();
    }
}
