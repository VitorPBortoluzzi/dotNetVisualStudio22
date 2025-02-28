namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media, somaMedia;
            Console.WriteLine("Atribuindo 3 notas para o aluno!");
            n1 = 7.5;
            Console.WriteLine("Nota 1 igual a: " + n1);
            n2 = 9.9;
            Console.WriteLine("Nota 2 igual a: " + n2);
            n3 = 0.7;
            Console.WriteLine("Nota 3 igual a: " + n3);

            somaMedia = n1 + n2 + n3;
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("Média do aluno: " + media);
            Console.WriteLine("Média do aluno m2: " + somaMedia / 3);
            Console.WriteLine("Média Arredondada: " + media.ToString("n2"));

            int i;
            i = 0;
            Console.WriteLine("i = : "+i);
            i = i + 1;
            Console.WriteLine("i = : " + i);
            i = i++;
            Console.WriteLine("i = : " + i);
            i += 1;
            Console.WriteLine("i = : " + i);
            i += 2;
            Console.WriteLine("i = : " + i);
            i = i + 3;
            Console.WriteLine("i = : " + i);
        }   
    }
}