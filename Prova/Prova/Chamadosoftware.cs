using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Chamadosoftware : Chamado
    {
        public Chamadosoftware(string Titulo, string Descricao) : base(Titulo, Descricao)
        {
            /*
            Desnecessário já que está herdando de Chamado todo o construtor e se refere a valores do construtor de chamado
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            Executar();
             */
        }

        public override void Executar()
        {
            Status = "Em Atendimento";
            Console.WriteLine("Executando diagnóstico e resinstalação de software...");
        }
    }
}
