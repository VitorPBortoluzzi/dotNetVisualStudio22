namespace Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo, descricao;

            Console.WriteLine("Digite um título para o seu chamado: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Digite a descricao para o seu chamado: ");
            descricao = Console.ReadLine();



            while (true)
            {
                Console.WriteLine("Classifique o seu tipo de Chamado em [1-Hardware] || [2-Software]");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    ChamadoHardware chamadoHardware = new ChamadoHardware(titulo, descricao);
                    Console.WriteLine("Atendimento de Hardware: ");
                    chamadoHardware.Exibir();
                    break;
                }
                if (opcao == 2)
                {
                    Chamadosoftware chamadosoftware = new Chamadosoftware(titulo, descricao);
                    Console.WriteLine("Atendimento de Software");
                    chamadosoftware.Exibir();
                    break;
                }
                else Console.WriteLine("Opção inválida");
            }



        }
    }
}