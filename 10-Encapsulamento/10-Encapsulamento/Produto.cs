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

        public string Nome { 
            get { return _nome; }//{get => _nome;
            set { _nome = value; }//set => _nome = value}
        }

        public int Codigo
        {
            get { return _codigo; }//get => _codigo;
            set { _codigo = value; }
        }

        public double Valor
        {
            get { return _valor; }//get => _valor;
            set { _valor = value; }
        }

        //Produto prop <tab tab>
        public int Quantidade { get; set; }

        public void Exibir()
        {
            Console.WriteLine("Código: "+ _codigo);
            Console.WriteLine("Nome: "+_nome);
            Console.WriteLine("Valor: "+Valor);
            Console.WriteLine("Quantidade: "+Quantidade);
        }
    }
}
