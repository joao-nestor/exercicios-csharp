using System.Net;

namespace jogo_da_velha;

public class Program
{
    public static char[,] table =
    {
        { '/', '/', '/' },
        { '/', '/', '/' },
        { '/', '/', '/' }
    };

    public static void Main()
    {
        Console.WriteLine("==========JOGO DA VELHA==========");
        bool continueGame = true;

        while (continueGame)
        {
            while (!VerifyVictory('X') && !VerifyVictory('O'))
            {
                PlayerTurn();
                if (VerifyVictory('X'))
                {
                    Console.WriteLine("Você ganhou!");
                    break;
                }
                else if (IsDraw())
                {
                    Console.WriteLine("É um empate!");
                    break;
                }
                MachineTurn();
                if (VerifyVictory('O'))
                {
                    Console.WriteLine("A máquina ganhou! Você perdeu!");
                    break;
                }
                else if (IsDraw())
                {
                    Console.WriteLine("É um empate!");
                    break;
                }
            }

            Console.WriteLine("Quer continuar jogando? (Sim/Não)");
            string readPlayerRes = Console.ReadLine();

            switch (readPlayerRes.ToLower())
            {
                case "s":
                case "sim":
                    Console.WriteLine("Recomeçando...");
                    continueGame = true;
                    ResetTable();
                    break;
                case "n":
                case "não":
                case "nao":
                    Console.WriteLine("Obrigado por jogar!");
                    continueGame = false;
                    break;
                default:
                    Console.WriteLine("Digite sim ou não!");
                    break;
            }
        }
    }

    public static void Table()
    {
        Console.WriteLine($"{table[0, 0]} | {table[0, 1]} | {table[0, 2]}");
        Console.WriteLine("--+---+---");
        Console.WriteLine($"{table[1, 0]} | {table[1, 1]} | {table[1, 2]}");
        Console.WriteLine("--+---+---");
        Console.WriteLine($"{table[2, 0]} | {table[2, 1]} | {table[2, 2]}");
        Console.WriteLine("==========");
    }

    public static void PlayerTurn()
    {
        bool hasPlayerPlayed = false;
        while (!hasPlayerPlayed)
        {
            Console.WriteLine("Onde quer colocar o X (1-9)?");
            string readResponse = Console.ReadLine();

            if (int.TryParse(readResponse, out int number))
            {
                switch (number)
                {
                    case 1:
                        if (isValidSpot(0, 0) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[0, 0] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 2:
                        if (isValidSpot(0, 1) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[0, 1] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 3:
                        if (isValidSpot(0, 2) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[0, 2] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 4:
                        if (isValidSpot(1, 0) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[1, 0] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 5:
                        if (isValidSpot(1, 1) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[1, 1] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 6:
                        if (isValidSpot(1, 2) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[1, 2] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 7:
                        if (isValidSpot(2, 0) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[2, 0] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 8:
                        if (isValidSpot(2, 1) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[2, 1] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    case 9:
                        if (isValidSpot(2, 2) == false)
                        {
                            Console.WriteLine("Esse lugar está preenchido!");
                            hasPlayerPlayed = false;
                        }
                        else
                        {
                            table[2, 2] = 'X';
                            hasPlayerPlayed = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Digite um número de 1 a 9!");
                        hasPlayerPlayed = false;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Erro...");
            }
        }
        Console.WriteLine("Vez do jogador:");
        Table();
    }

    public static void MachineTurn()
    {
        Random computer = new Random();
        bool hasMachinePlayed = false;

        while (!hasMachinePlayed)
        {
            int computerChoice = computer.Next(1, 10);

            switch (computerChoice)
            {
                case 1:
                    if (isValidSpot(0, 0) == false) hasMachinePlayed = false;
                    else
                    {
                        table[0, 0] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 2:
                    if (isValidSpot(0, 1) == false) hasMachinePlayed = false;
                    else
                    {
                        table[0, 1] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 3:
                    if (isValidSpot(0, 2) == false) hasMachinePlayed = false;
                    else
                    {
                        table[0, 2] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 4:
                    if (isValidSpot(1, 0) == false) hasMachinePlayed = false;
                    else
                    {
                        table[1, 0] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 5:
                    if (isValidSpot(1, 1) == false) hasMachinePlayed = false;
                    else
                    {
                        table[1, 1] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 6:
                    if (isValidSpot(1, 2) == false) hasMachinePlayed = false;
                    else
                    {
                        table[1, 2] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 7:
                    if (isValidSpot(2, 0) == false) hasMachinePlayed = false;
                    else
                    {
                        table[2, 0] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 8:
                    if (isValidSpot(2, 1) == false) hasMachinePlayed = false;
                    else
                    {
                        table[2, 1] = 'O'; hasMachinePlayed = true;
                    }
                    break;
                case 9:
                    if (isValidSpot(2, 2) == false) hasMachinePlayed = false;
                    else
                    {
                        table[2, 2] = 'O'; hasMachinePlayed = true;
                    }
                    break;
            }
        }
        Console.WriteLine("Vez da máquina:");
        Table();
    }

    public static bool isValidSpot(int row, int column)
    {
        if (table[row, column] != '/') return false;
        else return true;
    }

    public static bool VerifyVictory(char player)
    {
        for (int k = 0; k < 3; k++)
        {
            if (table[0, k] == player && table[1, k] == player && table[2, k] == player)
            {
                return true;
            }
            if (table[k, 0] == player && table[k, 1] == player && table[k, 2] == player)
            {
                return true;
            }
            if (table[0, 0] == player && table[1, 1] == player && table[2, 2] == player)
            {
                return true;
            }
            if (table[0, 2] == player && table[1, 1] == player && table[2, 0] == player)
            {
                return true;
            }
        }
        return false;
    }
    
    public static bool IsDraw()
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (table[i, j] == '/') {
                    return false;
                }
            }
        }
        return !VerifyVictory('X') && !VerifyVictory('O');
    }

    public static void ResetTable()
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = '/';
            }
        }
    }
}