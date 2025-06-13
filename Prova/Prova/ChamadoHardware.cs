using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class ChamadoHardware : Chamado
    {
        public ChamadoHardware(string Titulo, string Descricao) : base(Titulo, Descricao)
        {
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            Executar();
        }

        public override void Executar()
        {
            Status = "Em Atendimento";
            Console.WriteLine("Analisando componentes de hardware...");
        }
    }
}
