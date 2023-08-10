using System;

class Program
{
    public static void Main(string[] args)
    {

        EscapeRoom myRoom = new EscapeRoom();
        Agares agares = new Agares();
        Furfur furfur = new Furfur();
        Belphegor bel = new Belphegor();

        while (true)
        {
            Console.WriteLine(
          @"Seja bem-vindo(a), ao nosso Escape Room,
 --------------------------------------
| 1 - Começar o jogo.                  |
| 2 - Como o jogo funciona.            |
| 3 - Bestiario                        |
| 4 - Creditos                         |
| 5 - Sair                             |
 -------------------------------------");

            Console.WriteLine();
            int input;
            Console.Write("Entre com um comando: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == 1)
                {
                    Console.Clear();
                    myRoom.StartRoom();
                }
                else if (input == 2)
                {

                    Console.WriteLine();
                    Console.WriteLine(@"O objetivo do jogo é investigar a sala para descobrir as pistas e achar um codigo de 3 digitos para abrir a porta para a proxima area");

                }
                else if (input == 3)
                {
                    agares.displayinfo(agares.GetHierarquia());
              
                    furfur.displayinfo(furfur.GetHierarquia());

                    bel.displayinfo(bel.GetHierarquia());
                }
                else if (input == 4)
                {

                    Console.WriteLine();
                    Console.WriteLine("Projeto das aulas de POO");

                }
                else if (input == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Adeus");
                    Console.Clear();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("O comando {0} não existe =(", input);
                }
            }
            else
            {
                Console.WriteLine("Esse Comando não existe =( , use um dos numeros do menu");
            }


        }

    }
}