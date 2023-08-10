class Belphegor : Criatura
{
    string hierarquia;

    public string GetHierarquia()
    {
        return hierarquia;
    }

    public Belphegor()
    {
        hierarquia = "Duque dos Infernos";
        nome = "Barbatos";
        descricao = "Ele é retratado como um velho barburdo com 2 chifres, sentado em um vaso, ele seduz as pessoas com promessas de riquezas";
        danoCriatura = 3;
    }

}
