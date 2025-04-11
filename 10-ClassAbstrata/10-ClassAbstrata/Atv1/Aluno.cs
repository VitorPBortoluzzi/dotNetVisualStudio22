using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv1
{
    internal class Aluno : Pessoa
    {
        public string Matricula;

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o aluno {Nome}, tenho {Idade} anos e imnha matrícula é {Matricula}");
        }
    }
}
