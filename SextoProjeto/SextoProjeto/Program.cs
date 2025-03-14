namespace SextoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(<inicio>; <condicional>; <incremento+/->
            //for (int i = 0; i < 5; i++){
            //    Console.WriteLine("Hello, World!");
            //}

            ////while(<enquanto>){~<faça>}
            //int j=0;
            //while (j < 5) {
            //    Console.WriteLine("Hello, Fim de Mundo!");
            //    j++;
            //}

            ////do{<faça>} while(<enquanto>);
            //int k = 0;
            //do{
            //    Console.WriteLine("Ola, Paraíso!");
            //    k++;
            //} while (k < 5);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i vale " + i);
                if (i == 7)
                {
                    Console.WriteLine("Encerrando Laço");
                    break;
                }
            }

            for (int i = 10; i > 0; i--)
            {

                if (i == 5)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("i vale " + i);
                }
            }

        }
    }
}