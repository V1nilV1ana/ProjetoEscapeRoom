using System;
class Objetos
{
    private string Nome;
    private string Descrição;

    public Objetos(string nome, string descrição)
    {
        Nome = nome;
        Descrição = descrição;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"você inspeciona o {Nome}.");
        Console.WriteLine(Descrição);
        Console.WriteLine("(pressione qualquer tecla para continuar)");
        Console.ReadKey(true);
    }
    public void imprimirArte(string textFile)
    {
        string[] lines = System.IO.File.ReadAllLines(textFile);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}