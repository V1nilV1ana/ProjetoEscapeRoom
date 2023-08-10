using System;
class Door
{
    private string Code;

    public Door(string code)
    {
        Code = code;
    }
    public bool Fuga()
    {
        Console.WriteLine("Você se aproxima e tenta a porta. Está bloqueado e precisa de um código...");
        Console.WriteLine("Por favor insira um código");
        string PlayerGuess = Console.ReadLine().ToLower().Trim();
        if (PlayerGuess == Code)
        {
            Console.WriteLine("Clique... o cadeado cai. você escapou!");
            Console.WriteLine("(pressione qualquer tecla para continuar)");
            Console.ReadKey(true);
            return true;
        }
        else
        {
            Console.WriteLine("nada aconteceu.. acho que o código estava errado");

        }
        Console.WriteLine("(pressione qualquer tecla para continua)");
        Console.ReadKey(true);
        return PlayerGuess == Code;

    }
    public void imprimirPortas(string textFile)
    {
        string[] lines = System.IO.File.ReadAllLines(textFile);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}