namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double b;
            char c;
            string nome;
            Console.WriteLine("Digite um número int : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("O Numero digitado foi: "+x);

            Console.WriteLine("Digite um número double: (use ,)");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("O Numero digitado foi: " + b);

            Console.WriteLine("Digite um caracter: ");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("O Numero digitado foi: " + c);

            Console.WriteLine("Digite um nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O Numero digitado foi: " + nome);
        }
    }
}