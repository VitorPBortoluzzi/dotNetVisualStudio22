using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv2
{
    abstract class Veiculo
    {
        public string Marca;
        public string Modelo;

        public abstract void Dirigir();
    }
}
