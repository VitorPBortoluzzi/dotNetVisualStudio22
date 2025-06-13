namespace QuartoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //Console.WriteLine("Digite um número: ");
            //num = int.Parse(Console.ReadLine());

            //if (num == 0){ Console.WriteLine("O numero é 0");
            //}else if (num > 0) { Console.WriteLine("Positivo");
            //    }else { Console.WriteLine("Negativo"); 
            //        }


            //testar se um numero é divisivel por 2;
            //int num;
            //Console.WriteLine("Digite um numero para verificar sua divisibilidade por 2: ");
            //num = int.Parse(Console.ReadLine());


            //if (num % 2 == 0) { Console.WriteLine("O numero " + num + " é divisivel por 2"); }
            //if (num % 4 == 0) { Console.WriteLine("O numero " + num + " é divisivel por 4"); }
            //if (num % 8 == 0) { Console.WriteLine("O numero " + num + " é divisivel por 8"); }

            //mostrar se um numero é divisivel por 2,3 e 4 ao mesmo tempo
            int num;
            Console.WriteLine("Digite um numero para verificar sua divisibilidade por 2,3 & 4 simultaneamente: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 && num % 3 == 0 && num % 4 == 0) { Console.WriteLine("O numero é simultaneamente divisivel por 2,3 & 4"); }
            else { Console.WriteLine("Não é divisivel simultaneamente por 2,3 & 4"); }

        }
    }
}