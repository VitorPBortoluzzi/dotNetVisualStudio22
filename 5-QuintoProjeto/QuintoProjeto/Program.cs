namespace QuintoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado;
            char op;
            Console.WriteLine("Entre com o numero 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero 2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma operação:");
            Console.WriteLine("+ --> Para somar");
            Console.WriteLine("- --> Para subtrair");
            Console.WriteLine("* --> Para multiplicar");
            Console.WriteLine("/ --> Para dividir");
            Console.Write("Operador: ");
            op = char.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: ");
            //if (op == '+')
            //{
            //    resultado = n1 + n2;
            //    Console.WriteLine(n1 + " + " + n2 + " = " + resultado);
            //}
            //else if (op == '-')
            //{
            //    resultado = n1 - n2;
            //    Console.WriteLine(n1 + " - " + n2 + " = " + resultado);
            //}
            //else if (op == '*')
            //{
            //    resultado = n1 * n2;
            //    Console.WriteLine(n1 + " * " + n2 + " = " + resultado);
            //}
            //else if (op == '/')
            //{
            //    resultado = n1 / n2;
            //    Console.WriteLine(n1 + " / " + n2 + " = " + resultado);
            //}
            //else
            //{
            //    Console.WriteLine("operação invalida");
            //}
            switch (op)
            {
                case '+':
                    resultado = n1 + n2;
                    Console.WriteLine(n1 + " + " + n2 + " = " + resultado);
                    break;
                case '-':
                    resultado = n1 - n2;
                    Console.WriteLine(n1 + " - " + n2 + " = " + resultado);
                    break;
                case '*':
                    resultado = n1 * n2;
                    Console.WriteLine(n1 + " * " + n2 + " = " + resultado);
                    break;
                case '/':
                    resultado = n1 / n2;
                    Console.WriteLine(n1 + " / " + n2 + " = " + resultado);
                    break;
                default:
                    Console.WriteLine("operação invalida");
                    break;

            }
        }
    }
}