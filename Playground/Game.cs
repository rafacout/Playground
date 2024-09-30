namespace Playground;

public static class Game
{
    public static void Play()
    {
        string mesagemdeboasvindas = "seja bem vindo ao Gotinha de numeros ";
        Console.WriteLine();

        void ExibirLogo()
        {
            Console.WriteLine(@" 
░██████╗░░█████╗░████████╗██╗███╗░░██╗██╗░░██╗░█████╗░  ██████╗░███████╗
██╔════╝░██╔══██╗╚══██╔══╝██║████╗░██║██║░░██║██╔══██╗  ██╔══██╗██╔════╝
██║░░██╗░██║░░██║░░░██║░░░██║██╔██╗██║███████║███████║  ██║░░██║█████╗░░
██║░░╚██╗██║░░██║░░░██║░░░██║██║╚████║██╔══██║██╔══██║  ██║░░██║██╔══╝░░
╚██████╔╝╚█████╔╝░░░██║░░░██║██║░╚███║██║░░██║██║░░██║  ██████╔╝███████╗
░╚═════╝░░╚════╝░░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

     ███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░░██████╗
     ████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗██╔════╝
     ██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║╚█████╗░
     ██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║░╚═══██╗
     ██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝██████╔╝
     ╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═════╝░
    ");

            Console.WriteLine(mesagemdeboasvindas);
            Console.WriteLine();
            Console.WriteLine("ENTER");
            Console.ReadKey();
        }

        ExibirLogo();

        Random numeroNovo = new Random();
        int N1 = numeroNovo.Next(0, 11);

        void ExibirEntradaDoUsuario()
        {
            Console.WriteLine("Olá usuário digite um número de 0 a 10.");
        }

        ExibirEntradaDoUsuario();
        string Escolhadenumero = Console.ReadLine();

        bool conversaoBemSucedida = int.TryParse(Escolhadenumero, out int numeroUsuario);

        if (conversaoBemSucedida)
        {
            if (N1 == numeroUsuario)
            {
                Console.WriteLine("Parabéns você acertou !!!!");
            }
            else if (N1 != numeroUsuario)
            {
                Console.WriteLine("Sinto muito você errou ");
            }
            else
            {
                Console.WriteLine("nem tem essa opção de número ");
            }

            Console.WriteLine($"o seu numero é {N1}");
        }
        else
        {
            Console.WriteLine($"O valor digitado não é um numero: {Escolhadenumero}");
        }
    }
}