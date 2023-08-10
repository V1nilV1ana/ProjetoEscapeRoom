class Furfur : Criatura
{
    string hierarquia;

    public string GetHierarquia()
    {
        return hierarquia;
    }

    public Furfur()
    {
        hierarquia = "Grande Fidalgo do inferno";
        nome = "Furfur";
        descricao = "Ele é retratado como um veado ou veado alado , e também como um anjo, é um mentiroso, a não ser que seja obrigado a entrar num triângulo mágico onde ele somente dá respostas verdadeiras para cada pergunta, falando com uma voz grossa..";
        danoCriatura = 2;
    }

}
