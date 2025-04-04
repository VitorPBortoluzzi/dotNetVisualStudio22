namespace Atv_Projeto9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1- Escreva uma classe Aluno contendo todos os atributos de um aluno. Faça métodos para apresentar os dados.
            // Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.

            Console.WriteLine("1)");

            String nome;
            int matricula, idade, semestre;

            Console.WriteLine("Digite o nome do Aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a matricula do Aluno");
            matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do Aluno");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a semestre do Aluno");
            semestre = int.Parse(Console.ReadLine());

            Aluno al = new Aluno(nome, matricula, idade, semestre);

            al.dadosAluno();

            Console.WriteLine("-------------");
            Console.WriteLine("2)");
            // 2- Crie uma classe Livro que represente os dados básicos de um livro,
            // além destes, criar um atributo do tipo boolean chamado emprestado.
            // Crie métodos emprestar e devolver que altera o atributo emprestado
            // Crie um método construtor que receba todos os valores por parâmetros,
            // exceto o atributo emprestado que obrigatoriamente deve ser inicializado como false
            // Faça a leitura pelo teclado dos atributos para instanciar dois livros

            string titulo, autor, genero;
            int anoPublicacao;

            Console.WriteLine("Digite o titulo do livro:");
            titulo = Console.ReadLine();

            Console.WriteLine("Digite o autor do livro:");
            autor = Console.ReadLine();

            Console.WriteLine("Digite o genero do livro:");
            genero = Console.ReadLine();

            Console.WriteLine("Digite o ano de publicação do livro:");
            anoPublicacao = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, genero, anoPublicacao);
            livro.emprestar();
            livro.emprestar();
            livro.devolver();
            livro.devolver();

            Console.WriteLine("-------------");

            Console.WriteLine("3)");
        }
    }
}
