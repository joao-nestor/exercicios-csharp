namespace ternario_e_manstring;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma palavra:");
        string readWord = Console.ReadLine();
        string word = readWord.Length <= 2 ? "" : readWord[1..^1];

        Console.WriteLine($"Tirando a primeira e última letra: {word}");
    }
}