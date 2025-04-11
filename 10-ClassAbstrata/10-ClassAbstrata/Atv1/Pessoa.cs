using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv1
{
    abstract class Pessoa
    {
        public string Nome;
        public int Idade;

        public abstract void Apresentar();
    }
}
