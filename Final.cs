using System;
class Final
{
    private Objetos Banheira;
    private Objetos Pia;
    private Objetos Janela;
    private Door Bau;
    private bool afuga;
    Belphegor Bel = new Belphegor();
    Dano dmg = new Dano();

    public Final()
    {
        Banheira = new Objetos("Banheira chei de liquido desconhecido", "Você puxa a tampa do ralo. Quando a banheira fica vazia você encontra um colar. o colar tem uma foto de uma mulher com um nome logo abaixo,\"Bella Belinha\"e do lado oposto uma data “X / XXXI “  Você lembra que é uma data comemorativa ");

        Pia = new Objetos("Um pia", "Quando você se aproxima ve um frasco com algo escrito\"aplicado sobre o globo ocular\" você inclina a cabeça para trás e joga o líquido no seu olho quando vc abre os olhos aparece uma frase no seu eu rosto hora do diabo");

        Janela = new Objetos("Uma janela com varias tabuas", "Ao olhar pela fresta da janela. você encara uma sala mal iluminada, com \"5\" silhuetas que te seguem com um olhar frio e completamente macabro, elas anunciam que o fim desta jornada está chegando e que quando você falhar eles estarão presentes no banquete juntos aos outros apreciando sua carne  ");

        Bau = new Door("513");
    }

    public void StartFim(Jogador jog)
    {
        Console.WriteLine("Ao passa pela porta agora se encontra em um banheiro");
        Console.WriteLine("Nesse lugar há uma janela com tábuas, abaixo uma banheira cheia com um líquido estranho,no canto direito uma pia com manchas de sangue com espelho e desta vez não existe uma porta mas ao invez disso um bau no meio do banheiro");
        Console.WriteLine("(pressione qualquer tecla para continuar)");
        Console.ReadKey(true);

        while (!afuga)
        {
            jog.Status();
            string choice = Navigate();

            if (choice == "1")
            {
                string text = @"Banheira.txt";
                Banheira.imprimirArte(text);
                Banheira.DisplayInfo();
            }
            else if (choice == "2")
            {
                string text = @"pia.txt";
                Pia.imprimirArte(text);
                Pia.DisplayInfo();
            }
            else if (choice == "3")
            {
                string text = @"janela.txt";
                Janela.imprimirArte(text);
                Janela.DisplayInfo();
            }
            else if (choice == "4")
            {
                string text = @"bau.txt";
                Bau.imprimirPortas(text);
                bool wasSuccessful = Bau.Fuga();
                if (afuga = wasSuccessful)
                {
                    Console.ReadKey(true);
                    Console.WriteLine("Parabéns você consegui passa pelos desafios sua recompensa é a essa =) e tambem esta livre para ir embora Adeus");
                    Console.WriteLine("aperte qualquer tecla para sair..");
                    Console.ReadKey(true);
                    Console.Clear();

                }
                else
                {
                    dmg.Danolevado(jog, Bel);
                }

            }
            else
            {
                EscolhaInvalida();
            }
        }
    }

    private void EscolhaInvalida()
    {
        Console.WriteLine("essa não é uma opção válida.tente novamente");
        Console.WriteLine("pressione qualquer tecla para continuar");
        Console.ReadKey(true);
    }
    private string Navigate()
    {
        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Onde você gostaria de olhar?");
        Console.WriteLine(" 1) Banheira\n 2) Pia\n 3) Janela\n 4) Bau\n");
        string navigationChoice = Console.ReadLine().Trim();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~\n");
        return navigationChoice;
    }
}