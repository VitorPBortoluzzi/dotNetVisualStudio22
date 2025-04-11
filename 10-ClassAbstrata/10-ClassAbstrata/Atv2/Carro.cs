using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ClassAbstrata.Atv2

{
    internal class Carro : Veiculo
    {
        public int Portas;

        public override void Dirigir() {
            Console.WriteLine($"Diriginto a {Marca}{Modelo} com {Portas}");
        }
    }
}
