using System;
class Fase2
{
    private Objetos Cama;
    private Objetos Parede;
    private Objetos Armario;
    private Door PortaMadeira;
    private bool afuga;
    Furfur Fur = new Furfur();
    Dano dmg = new Dano();

    public Fase2()
    {
        Armario = new Objetos("Você Abre o armario e encontra uma nova carta", "Eu sou cada pesadelo que você já teve. Eu sou o seu pior sonho se tornando realidade.Eu sou tudo o que você sempre teve medo.. Sem lágrimas, por favor. É um desperdício de bom sofrimento. Deveria trancar você nessa sala, trancar a sete chaves. Só assim você ficaria vivo e protegidas de todos os males da vida, incluindo a mim."
);

        Cama = new Objetos("Cama ensanguentada", "Quando você se aproxima da cama,o sangue começa a formar uma frase: \"Sabia que quando o coração para, o cérebro ainda funciona por 7 minutos? Nós ainda temos 6 minutos para brincar.\"");

        Parede = new Objetos("Parede com marcas", " Quando você se aproxima da Parede,vc percebe que a mancha de sangue na verdade é um símbolo \"uma estrela de quatro pontas\"");

        PortaMadeira = new Door("747");
    }

    public void StartFase2(Jogador jog)
    {
        Console.WriteLine("Você entra em um novo comodo e desta vez é um quarto com muito sangue.");
        Console.WriteLine("Nesse quarto, ha mais uma porta so que feita de madeira, uma cama ensanguentada e nao só mas tambem as paredes, e em um há armario fechado, e nas paredes você consegue ver que há marca");
        Console.WriteLine("(pressione qualquer tecla para continuar)");
        Console.ReadKey(true);

        while (!afuga)
        {
            jog.Status();
            string choice = Navigate();

            if (choice == "1")
            {
                string text = @"Armario.txt";
                Armario.imprimirArte(text);
                Armario.DisplayInfo();
            }
            else if (choice == "2")
            {
                string text = @"cama.txt";
                Cama.imprimirArte(text);
                Cama.DisplayInfo();
            }
            else if (choice == "3")
            {
                string text = @"mensagem.txt";
                Parede.imprimirArte(text);
                Parede.DisplayInfo();
            }
            else if (choice == "4")
            {
                string text = @"porta.txt";
                PortaMadeira.imprimirPortas(text);
                bool wasSuccessful = PortaMadeira.Fuga();
                if (afuga = wasSuccessful)
                {
                    Console.WriteLine("Parabéns você consegui passa pelo segund desafio. só mais um para o seu grande premio!!");
                    Console.WriteLine("aperte qualquer tecla para sair..");
                    Console.ReadKey(true);
                    Console.Clear();
                    Final fim = new Final();
                    fim.StartFim(jog);

                }
                else
                {
                    dmg.Danolevado(jog, Fur);
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
        Console.WriteLine(" 1) Armario\n 2) Cama\n 3) Parede\n 4) Porta de madeira\n");
        string navigationChoice = Console.ReadLine().Trim();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~\n");
        return navigationChoice;
    }
}