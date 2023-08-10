using System;
class Jogador
{
    string nomeJogador;
    int vidaAtual;
    int vidaMaxima;


    public Jogador(string name)
    {
        nomeJogador = name;
        vidaAtual = 10;
        vidaMaxima = 10;
    }

    public void Status()
    {
        if (nomeJogador == "")
        {
            nomeJogador = "???";
        }
        Console.WriteLine("{0}, Vida: {1}/{2}", nomeJogador, vidaAtual, vidaMaxima);

    }

    public string GetNome()
    {
        return nomeJogador;
    }

    public virtual int GetVA()
    {
        return vidaAtual;
    }

    public int GetVM()
    {
        return vidaMaxima;
    }

    public void SetVA(int VA)
    {
        vidaAtual = VA;
    }


}


