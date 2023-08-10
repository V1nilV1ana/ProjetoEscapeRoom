using System;
class Criatura
{
    protected string nome;
    protected string descricao;
    protected int danoCriatura;

    public Criatura(string name, string desc, int dmg)
    {
        nome = name;
        descricao = desc;
        danoCriatura = dmg;
    }
    public Criatura()
    {
        nome = "exemplo1";
        descricao = "desc1";
        danoCriatura = 1;
    }

    public string GetNome()
    {
        return nome;
    }

    public string GetDesc()
    {
        return descricao;
    }

    public int GetDano()
    {
        return danoCriatura;
    }

    public void displayinfo(string h)
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine();
        Console.WriteLine("Hirearquia: " + h);
        Console.WriteLine();
        Console.WriteLine("Descrição: " + descricao);
        Console.WriteLine();
        Console.WriteLine("******************************");
    }

}