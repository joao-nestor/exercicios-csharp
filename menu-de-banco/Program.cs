namespace menu_de_banco;

public class Program
{
    public static void Main()
    {
        int option = 0;
        bool Continue = true;
        double balance = 1000;

        do
        {
            string initialScreen = "";
            string conWithdraw = "";
            Console.WriteLine("==========MENU DE BANCO==========");
            Console.WriteLine("Selecione uma das opções a seguir:");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Sair");
            Console.WriteLine("Como deseja prosseguir?");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"Saldo atual: {balance} reais.");
                    do
                    {
                        Console.WriteLine("Voltar a tela inicial? (s/N)");
                        initialScreen = Console.ReadLine();

                        switch (initialScreen)
                        {
                            case "s":
                            case "S":
                                option = 0;
                                Continue = true;
                                break;
                            case "n":
                            case "N":
                                option = 3;
                                Continue = false;
                                Console.WriteLine("Obrigado por usar nosso banco!");
                                break;
                            default:
                                Console.WriteLine("Digite sim ou não!");
                                break;
                        }
                    }
                    while (initialScreen != "s" && initialScreen != "S" && initialScreen != "n" && initialScreen != "N");

                    break;
                case 2:
                    do
                    {
                        Console.WriteLine("Quanto quer sacar?");
                        double withdrawnAmount = Convert.ToDouble(Console.ReadLine());

                        if (withdrawnAmount < 0)
                        {
                            Console.WriteLine("Não é possível sacar valores negativos");
                        }
                        else if (withdrawnAmount == 0)
                        {
                            Console.WriteLine("Transação inválida!");
                        }
                        else if (balance > 0 && withdrawnAmount <= balance)
                        {
                            balance -= withdrawnAmount;
                            Console.WriteLine($"Transação realizada com sucesso!\nSeu saldo atual é de {balance} reais.");
                        }
                        else
                        {
                            Console.WriteLine("Erro: saldo insuficiente!");
                        }

                        do
                        {
                            Console.WriteLine("Quer continuar sacando? (s/N)");
                            conWithdraw = Console.ReadLine();
                            switch (conWithdraw)
                            {
                                case "s":
                                case "S":
                                    option = 2;
                                    break;
                                case "n":
                                case "N":
                                    option = 0;
                                    break;
                                default:
                                    Console.WriteLine("Digite sim ou não!");
                                    break;
                            }
                        }
                        while (conWithdraw != "s" && conWithdraw != "S" && conWithdraw != "n" && conWithdraw != "N");
                    }
                    while (option == 2);

                    break;
                case 3:
                    Console.WriteLine("Obrigado por usar nosso banco!");
                    Continue = false;
                    break;
                default:
                    Console.WriteLine("Entrada inválida!\n");
                    break;
            }

        }
        while (Continue);

    }
}