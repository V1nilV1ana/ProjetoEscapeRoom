class Agares : Criatura
{
    string hierarquia;

    public string GetHierarquia()
    {
        return hierarquia;
    }

    public Agares()
    {
        hierarquia = "Grão-Duque do Inferno";
        nome = "Agares";
        descricao ="Um ancião decrépito e mau-encarado, montado num crocodilo e com um falcão pousado no punho, supostamente tem o poder de causar terremotos, de conceder a capacidade de encontrar pessoas fugitivas e o dom de línguas, sentindo particular prazer na hora de ensinar expressões pejorativas, imorais e proibidas.";
        danoCriatura = 1;
    }
     public Agares(string nomes)
    {
        hierarquia = "Grão-Duque do Inferno";
        nome = nomes;
        descricao ="Um ancião decrépito e mau-encarado, montado num crocodilo e com um falcão pousado no punho, supostamente tem o poder de causar terremotos, de conceder a capacidade de encontrar pessoas fugitivas e o dom de línguas, sentindo particular prazer na hora de ensinar expressões pejorativas, imorais e proibidas.";
        danoCriatura = 1;
    }


}
