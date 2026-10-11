namespace ex_do_while;

public class Program
{
    public static void Main()
    {
        int counter = 1;

        do
        {
            Console.WriteLine(counter);
            counter += 1;
        }
        while (counter <= 5);
    }
}