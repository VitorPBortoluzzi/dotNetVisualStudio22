namespace QuartoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0){ Console.WriteLine("O numero é 0");
            }else if (num > 0) { Console.WriteLine("Positivo");
                }else { Console.WriteLine("Negativo"); 
                    }
        }
    }
}