namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao começo do fim!!");
            int n1, n2, soma;
            n1 = 5;
            n2 = 25;
            Console.WriteLine("n1 é igual a: "+n1);
            Console.WriteLine("n2 é igual a: "+n2);
            Console.WriteLine("A soma é igual a: "+(n1+n2));
            soma = n1 + n2;
            Console.WriteLine("A variavel soma é igual a: "+soma);

            var dt = new DateTime();
            Console.WriteLine(dt);

            Console.WriteLine("Dia = "+dt.Day);
            Console.WriteLine("Mês = "+dt.Month);
            Console.WriteLine("Ano = "+dt.Year);
            Console.WriteLine("Hora = "+dt.Hour);
            Console.WriteLine("Minuto = "+dt.Minute);
            Console.WriteLine("DateTime agora: ");
            dt = DateTime.Now;
            Console.WriteLine("Dia = " + dt.Day);
            Console.WriteLine("Mês = " + dt.Month);
            Console.WriteLine("Ano = " + dt.Year);
            Console.WriteLine("Hora = " + dt.Hour);
            Console.WriteLine("Minuto = " + dt.Minute);
            Console.WriteLine(dt.Day+"/"+dt.Month+"/"+dt.Year);
            Console.WriteLine(dt);
        }
    }
}