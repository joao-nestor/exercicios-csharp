namespace adivinhe_o_numero;

public class Program
{
    static bool gameContinue = true;
    static int attempts = 1;
    public static void Main()
    {
        int playerNum = 0;

        Console.WriteLine("==========JOGO DE ADIVINHAÇÃO==========");

        do
        {
            Random randomNum = new Random();
            int secretNumber = randomNum.Next(1, 101);

            for (attempts = 1; attempts <= 7; attempts += 1)
            {
                Console.WriteLine("Digite um número de 1 a 100: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out playerNum) || playerNum > 100 || playerNum <= 0)
                {
                    if (attempts == 7)
                    {
                        Console.WriteLine("Você perdeu!");
                        TryAgain();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um número válido!");
                        Console.WriteLine($"Número de tentativas: {attempts}");
                    }
                }
                else if (playerNum != secretNumber && attempts == 7)
                {
                    Console.WriteLine("Você perdeu!");
                    TryAgain();
                    break;
                }
                else if (playerNum > secretNumber)
                {
                    Console.WriteLine("Tente um número menor!");
                    Console.WriteLine($"Número de tentativas: {attempts}");
                }
                else if (playerNum < secretNumber)
                {
                    Console.WriteLine("Tente um número maior");
                    Console.WriteLine($"Número de tentativas: {attempts}");
                }
                else
                {
                    Console.WriteLine($"Parabéns, você ganhou com {attempts} tentativas.");
                    TryAgain();
                    break;
                }
            }
        }
        while (gameContinue);

    }

    public static void TryAgain()
    {
        string tryAgain = "";
        do
        {
            Console.WriteLine("Quer tentar de novo? (s/N)");
            tryAgain = Console.ReadLine();
            switch (tryAgain)
            {
                case "s":
                case "S":
                    gameContinue = true;
                    break;
                case "n":
                case "N":
                    Console.WriteLine("Obrigado por jogar!");
                    gameContinue = false;
                    break;
                default:
                    Console.WriteLine("Digite se sim ou não!");
                    break;
            }
        }
        while (tryAgain != "s" && tryAgain != "S" && tryAgain != "n" && tryAgain != "N");

    }
}