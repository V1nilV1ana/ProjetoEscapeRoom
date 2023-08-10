using System;

class EscapeRoom
{
    private Objetos estante;
    private Objetos caveira;
    private Objetos pedaçodepapel;
    private Objetos janela;
    private Objetos pano;
    private Door PortaEsverdeada;
    private bool afuga;
    Jogador Player;
    Agares Aga = new Agares();
    Dano dmg = new Dano();

    public EscapeRoom()
    {
        estante = new Objetos("Estante de livros", "Com vários livros, \"mas apenas um chama sua atenção\" O seu titulo é livro com o Título é Agares o grão-duque do inferno você pegar ele e dentro so há rabiscos incompreensíveis");

        caveira = new Objetos("Uma Caveira humana", "que esta sorrindo com seus \"8\" dentes de marfin, que se ela pudesse falar ela contaria umas ótimas piadas.");

        pedaçodepapel = new Objetos("Pedaço de papel", "nele está escrito parabéns por assinar este contrato, neste jogo você deve descobrir a senha para a porta para escapar e se não conseguir tera que enfrentra um destino pior do que a morte, ela é uma combinação de \"3\" números espalhados pelo quarto e caso você ganhar terá a chance de viver mais um dia ou vários prêmios e por isso é muito importante ler e olhar com atenção para tudo em sua volta ");

        janela = new Objetos("Janela", "Ao olhar pela janela você encontra algo assustador do lado de fora te encarando");

        pano = new Objetos("Pano", "um dos objetos que parecem mais fora de lugar além da caveira, um pano furando e sujo nesta sala, \"você levanta o pano e para sua surpresa você não encontra nada zero\", nem um exame de aranhas que pensava que apareceria do nada,apenas uma decepção.");

        PortaEsverdeada = new Door("831");

    }
    public void StartRoom()
    {
        Console.Title = "Escape";
        Console.WriteLine("Você acorda e olha em volta grogue.");
        Console.WriteLine("Você se encontra em um corredor escuro, na sua frente há uma porta vermelha e atrás de você só há uma escuridão, na porta está escrito para entrar nesse mundo de sonhos é necessário que eu obtenha seu nome para consolidar o contrato...");
        Console.WriteLine("Me dê um nome");
        string nomeA = Console.ReadLine();
        Player = new Jogador(nomeA);
        if (nomeA == "")
        {
            Console.WriteLine("Então que pena parece que você esqueceu seu nome");
        }
        else
        {
            Console.WriteLine("Então seu nome é " + Player.GetNome());
        }
        Console.WriteLine();
        Console.WriteLine("Depois que o contrato é feito, a porta se abre e você se encontra em uma sala.");
        Console.WriteLine("(pressione qualquer tecla para continuar)");
        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine("Essa sala você analisa e percebe que é pequena e muito bem cuidada, em um canto existe uma estante de livros no topo dela há uma caveira, no centro uma mesa com uma pedaço de papel, na parede do canto esquerdo há uma pequena janela, no direito um pedaço de pano com alguns furos e do lado oposto da onde vc se encontra numa porta esverdeada, vc olha para trás e porta pela qual você entrou não está mais lá, no seu lugar só ha uma parede");
        Console.WriteLine("(pressione qualquer tecla para continuar)");
        Console.ReadKey(true);

        while (!afuga)
        {
            Player.Status();
            string choice = Navigate();

            if (choice == "1")
            {
                string text = @"estante.txt";
                estante.imprimirArte(text);
                estante.DisplayInfo();
            }
            else if (choice == "2")
            {
                string text = @"skull.txt";
                caveira.imprimirArte(text);
                caveira.DisplayInfo();
            }
            else if (choice == "3")
            {
                string text = @"mensagem.txt";
                pedaçodepapel.imprimirArte(text);
                pedaçodepapel.DisplayInfo();
            }
            else if (choice == "4")
            {
                string text = @"pano.txt";
                pano.imprimirArte(text);
                pano.DisplayInfo();
            }
            else if (choice == "5")
            {
                string text = @"olho.txt";
                janela.imprimirArte(text);
                janela.DisplayInfo();
            }
            else if (choice == "6")
            {
                string text = @"porta.txt";
                PortaEsverdeada.imprimirPortas(text);
                bool wasSuccessful = PortaEsverdeada.Fuga();
                if (afuga = wasSuccessful)
                {
                    Console.WriteLine("Parabéns você consegui passa pelo primeiro desafio.Quando a porta se abre você ouve gritos da sala ao lado, você sabe que não tem muito tempo antes que os demonios venham atrás de você.");
                    Console.WriteLine("aperte qualquer tecla para sair..");
                    Console.ReadKey(true);
                    Console.Clear();
                    Fase2 stage2 = new Fase2();
                    stage2.StartFase2(Player);

                }
                else
                {
                    dmg.Danolevado(Player, Aga);
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
        Console.WriteLine(" 1) Estante de livros\n 2) Caveira\n 3)Pedaço de papel\n 4) Pano\n 5) Janela\n 6) Porta Esverdiada\n");
        string navigationChoice = Console.ReadLine().Trim();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~\n");
        return navigationChoice;
    }
}