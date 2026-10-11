namespace ex_foreach;

public class Program
{
    public static void Main()
    {
        string[] gamesList = {"Terraria", "Sekiro", "Dark Souls", "Elden Ring"};

        foreach (string game in gamesList)
        {
            Console.WriteLine(game);
        }
    }
}