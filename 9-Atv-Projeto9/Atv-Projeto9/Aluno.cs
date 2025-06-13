using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_Projeto9
{
    internal class Aluno
    {
        // 1- Escreva uma classe Aluno contendo todos os atributos de um aluno. Faça métodos para apresentar os dados.
        // Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.

        public String nome;
        public int matricula;
        public int idade;
        public int semestre;
        public char sexo;

        public Aluno(string nome, int matricula, int idade, int semestre, char sexo)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.idade = idade;
            this.semestre = semestre;
            this.sexo = sexo;
        }

        public void dadosAluno()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("nome:" + nome);
            Console.WriteLine("Matricula:" + matricula);
            Console.WriteLine("idade:" + idade);
            Console.WriteLine("semestre:" + semestre);
            Console.WriteLine("sexo:" + sexo);
            Console.WriteLine("----------------------");
        }
    }
}
