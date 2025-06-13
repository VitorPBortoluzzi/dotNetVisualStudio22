namespace SetimoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = -1;
            Console.WriteLine("Insira valores inteiros diferentes de 0");
            Console.WriteLine("Para encerrar insira 0");
            while (op != 0) {
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("op: " + op);
                if (op == 0) break;
            }
        }
    }
}