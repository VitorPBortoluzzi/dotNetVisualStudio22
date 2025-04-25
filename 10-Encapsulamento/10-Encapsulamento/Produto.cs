using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Encapsulamento
{
    internal class Produto
    {

        //Campo _<nome>
        private int _codigo;
        private string _nome;
        private double _valor;

        //Produto prop <tab tab>
        public int Quantidade { get; set; }


        public void Exibir()
        {
            Console.WriteLine("Código: "+ _codigo);
            Console.WriteLine("Nome: "+_nome);
            Console.WriteLine("Valor: "+_valor);
            Console.WriteLine("Quantidade: "+Quantidade);
        }
    }
}
