using System;
class Dano
{
    public void Danolevado(Jogador jog, Agares a1)
    {
        int dmg = jog.GetVA() - a1.GetDano();
        jog.SetVA(dmg);
        if (dmg <= 0)
        {
            Console.WriteLine("Game over");
            Console.WriteLine("Parece que seu tempo chegou a fim, adeus, você foi dado de comida para o crocodilo");
            Console.WriteLine("(pressione qualquer tecla para continuar)");
            Console.ReadKey(true);
            Console.Clear();
            Environment.Exit(0);
        }
        else if (dmg <= 9)
        {
            Console.WriteLine("Hora ja começamos com a bricandeira - diz uma voz grossa do lado de fora");
            Console.WriteLine("E derrepente o chao começa a tremer e você cai");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }
        else if (dmg <= 7)
        {
            Console.WriteLine("Vamos vamos tente escapar denovo e logo estarei ai com você, não se apresse pois tenho todo o tempo do mundo - diz uma voz grossa do lado de fora");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }
        else if (dmg <= 5)
        {
            Console.WriteLine("Desta vez você ouve um rugido");
            Console.WriteLine("Sim meu querido logo teremos um jantar para você - diz uma voz grossa do lado de fora");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }
        else if (dmg <= 3)
        {
            Console.WriteLine("Você não se sente bem e suas forças estao saindo do seu corpo");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }
        else if (dmg == 1)
        {
            Console.WriteLine("Você sente que essa vai ser sua ultima tentativa antes que algo realmente aconteça");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }

    }



    public void Danolevado(Jogador jog, Furfur f1)
    {
        int dmg = jog.GetVA() - f1.GetDano();
        jog.SetVA(dmg);
        if (dmg <= 0)
        {
            Console.WriteLine("Game over");
            Console.WriteLine("Parece que seu tempo chegou a fim");
            Console.WriteLine("(pressione qualquer tecla para continuar)");
            Console.ReadKey(true);
            Console.Clear();
            Environment.Exit(0);
        }
        else if (dmg <= 8)
        {
            Console.WriteLine("Vamos pequeno humano - diz uma voz quase angelical");
            Console.WriteLine("O sangue da sala forma espinhos e te furam");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), f1.GetDano());
        }
        else if (dmg <= 6)
        {
            Console.WriteLine("Mal posso esperar para ter mais um especime para os meus esperimentos - - diz uma voz quase angelical");
            Console.WriteLine("Agora a sala esta cheia de espinhos de sangue");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), f1.GetDano());
        }
        else if (dmg <= 4)
        {
            Console.WriteLine("Você ouve risadas de fora do do quarto");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), f1.GetDano());
        }
        else if (dmg <= 2)
        {
            Console.WriteLine("O seu sangue esta sendo absorvido pela sala");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), f1.GetDano());
        }
        else if (dmg == 1)
        {
            Console.WriteLine("Você sente que essa vai ser sua ultima tentativa");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), f1.GetDano());
        }

    }

    public void Danolevado(Jogador jog, Belphegor a1)
    {
        int dmg = jog.GetVA() - a1.GetDano();
        jog.SetVA(dmg);
        if (dmg <= 0)
        {
            Console.WriteLine("Game over");
            Console.WriteLine("A ultima coisa que você ve é um demonio sentado em um vaso");
            Console.WriteLine("(pressione qualquer tecla para continuar)");
            Console.ReadKey(true);
            Console.Clear();
            Environment.Exit(0);
        }
        else if (dmg <= 7)
        {
            Console.WriteLine("Por que você não desiste e fica aqui comigo pelo resto da eternidade - diz uma voz rouca");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }
        else if (dmg <= 4)
        {
            Console.WriteLine("Vamos só mais um pouco e logo terei sua alma - diz uma voz rouca");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }
        else if (dmg == 1)
        {
            Console.WriteLine("Sua visão esta escurecendo mais você ainda tem força para mais uma tentativa");
            Console.WriteLine("{0}, levou {1} de dano", jog.GetNome(), a1.GetDano());
        }

    }




}

