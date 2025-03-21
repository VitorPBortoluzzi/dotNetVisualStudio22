namespace _8_OivatoProjeto_Objeto_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Testando a classe pessoa");
            //Pessoa p = new Pessoa(); // instanciando um objeto;
            //p.nome = "Guilherme";
            //p.email = "email";
            //p.idade = 25;

            //Console.WriteLine("Existe a pessoa p");
            //Console.WriteLine("Nome: " + p.nome);
            //Console.WriteLine("Email: " + p.email);
            //Console.WriteLine("Idade: " + p.idade + " \n");

            //Pessoa p2 = new Pessoa();
            //p2.nome = "Vitor";
            //p2.email = "email";
            //p2.idade = 22;
            //Console.WriteLine("Nome: " + p2.nome);
            //Console.WriteLine("Email: " + p2.email);
            //Console.WriteLine("Idade: " + p2.idade + " \n");

            //Pessoa p3 = new Pessoa();
            //p3.nome = "Roger";
            //p3.email = "email";
            //p3.idade = 24;
            //Console.WriteLine("Nome: " + p3.nome);
            //Console.WriteLine("Email: " + p3.email);
            //Console.WriteLine("Idade: " + p3.idade + " \n");

            //Pessoa p4 = new Pessoa();
            //Console.WriteLine("Digite o nome da Pessoa: "); 
            //p4.nome = Console.ReadLine();
            //Console.WriteLine("Digite o email da Pessoa: ");
            //p4.email = Console.ReadLine();
            //Console.WriteLine("Digite a idade da Pessoa: ");
            //p4.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Pessoa: p4( "+p4.nome+" ; " + p4.email+" ; " + p4.idade + ";\n" );

            //Carro c1 = new Carro();
            //Console.WriteLine("Digite a marca do carro 1");
            //c1.marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo do carro 2");
            //c1.modelo = Console.ReadLine();
            //Console.WriteLine("Digite o ano de frabricação do carro 2");
            //c1.anoFabricado = int.Parse(Console.ReadLine());

            //Console.WriteLine("Carro: c1( " + c1.marca + " ; " + c1.modelo + " ; " + c1.anoFabricado + ";)\n");

            //Carro c2 = new Carro();
            //Console.WriteLine("Digite a marca do carro 2");
            //c2.marca = Console.ReadLine();
            //Console.WriteLine("Digite o modelo do carro 2");
            //c2.modelo = Console.ReadLine();
            //Console.WriteLine("Digite o ano de frabricação do carro 2");
            //c2.anoFabricado = int.Parse(Console.ReadLine());

            //Console.WriteLine("Carro: c2( " + c2.marca + " ; " + c2.modelo + " ; " + c2.anoFabricado + ";)\n");

            Livreo l1 = new Livreo();
            Livreo l2 = new Livreo();
            Livreo l3 = new Livreo();

            Console.WriteLine(" " + l1.titulo + l1.autor + l1.anoPublic);
            Console.WriteLine(" " + l2.titulo + l2.autor + l2.anoPublic);
            Console.WriteLine(" " + l3.titulo + l3.autor + l3.anoPublic);


        }
    }
}