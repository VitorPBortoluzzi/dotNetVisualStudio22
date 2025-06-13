using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv1
{
    internal class Professor : Pessoa
    {
        public string Disciplina;
        public override void Apresentar()
        {
            Console.WriteLine($"Sou o professor {Nome}, tenho {Idade} anos e leciono {Disciplina}.");
        }
    }
}
