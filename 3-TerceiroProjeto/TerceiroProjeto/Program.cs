namespace TerceiroProjeto
{
    using System.Globalization;
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //double b;
            //char c;
            //string nome;
            //Console.WriteLine("Digite um número int : ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("O Numero digitado foi: " + x);

            //Console.WriteLine("Digite um número double: (use ,)");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("O Numero digitado foi: " + b);

            //Console.WriteLine("Digite um caracter: ");
            //c = char.Parse(Console.ReadLine());
            //Console.WriteLine("O Numero digitado foi: " + c);

            //Console.WriteLine("Digite um nome: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("O Numero digitado foi: " + nome);

            //Faça a leitura de dois números double, faça as 4 operações matemáticas e apresente na tela os resultados

            double b1,b2;
            Console.WriteLine("Digite o primeiro número double: (use ,)");
            b1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o segundo número double: (use ,)");
            b2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("As operações básica entre eles são:\n ");
            double soma, subtracao, multiuplicacao, divisao;
            soma = b1 + b2;
            subtracao = b1 - b2;
            multiuplicacao = b1 * b2;
            divisao = b1/b2;
            Console.WriteLine("Soma: " +b1 + " + "+ b2 + " = " + soma);
            Console.WriteLine("Subtração: " + b1 + " - " + b2 + " = " + subtracao);
            Console.WriteLine("Multiplicação: " + b1 + " * " + b2 + " = " + multiuplicacao);
            Console.WriteLine("Divisão: " + b1 + " / " + b2 + " = " + divisao);
        }
    }
}