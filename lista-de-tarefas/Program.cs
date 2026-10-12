namespace lista_de_tarefas;

public class Program
{
    public static void Main()
    {
        bool contProgram = true;
        int userOption = 0;
        int optRemTask = 0;
        List<string> tasks = new List<string>();

        do
        {
            int index = 0;
            string moreTasks = "";
            int remTask = 0;
            Console.WriteLine("==========LISTA DE TAREFAS==========");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Exibir tarefas");
            Console.WriteLine("3. Remover tarefa");
            Console.WriteLine("4. Encerrar programa");
            Console.WriteLine("O que deseja fazer?");

            if (!int.TryParse(Console.ReadLine(), out userOption))
            {
                Console.WriteLine("Digite um número válido!");
                continue;
            }

            Console.WriteLine();

            switch (userOption)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Digite a tarefa: ");
                        string nameTask = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nameTask))
                        {
                            tasks.Add(nameTask);
                            Console.WriteLine("A tarefa foi adicionada!");
                        }
                        else
                        {
                            Console.WriteLine("A tarefa não pode ser vazia!");
                        }

                        do
                        {
                            Console.WriteLine("Deseja adicionar mais uma tarefa? (s/N)");
                            moreTasks = Console.ReadLine();

                            switch (moreTasks)
                            {
                                case "s":
                                case "S":
                                    userOption = 1;
                                    break;
                                case "n":
                                case "N":
                                    userOption = 2;
                                    break;
                                default:
                                    Console.WriteLine("Digite sim ou não!");
                                    break;
                            }
                        }
                        while (moreTasks != "s" && moreTasks != "S" && moreTasks != "n" && moreTasks != "N");
                    }
                    while (userOption == 1);

                    break;
                case 2:
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Ainda não há tarefas!");
                    }
                    else
                    {
                        foreach (string task in tasks)
                        {
                            Console.WriteLine($"{index + 1}. {task}");
                            index++;
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    do
                    {
                        Console.WriteLine("Quer remover:");
                        Console.WriteLine("1. Uma tarefa");
                        Console.WriteLine("2. Todas as tarefas");

                        if (!int.TryParse(Console.ReadLine(), out optRemTask))
                        {
                            Console.WriteLine("Digite um número válido!");
                            continue;
                        }

                        switch (optRemTask)
                        {
                            case 1:
                                Console.WriteLine("Digite o número da tarefa que deseja remover:");
                                if (!int.TryParse(Console.ReadLine(), out remTask))
                                {
                                    Console.WriteLine("Digite um número válido!");
                                    optRemTask = 0;
                                    continue;
                                }

                                if (tasks.Count == 0)
                                {
                                    Console.WriteLine("Ainda não há tarefas!");
                                }
                                else if (tasks.Count != 0)
                                {
                                    if (remTask >= 1 && remTask <= tasks.Count)
                                    {
                                        tasks.RemoveAt(remTask - 1);
                                        Console.WriteLine("A tarefa foi removida com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Essa tarefa não existe!");
                                        optRemTask = 0;
                                    }
                                }

                                break;
                            case 2:
                                if (tasks.Count == 0)
                                {
                                    Console.WriteLine("Ainda não há tarefas!");
                                }
                                else
                                {
                                    tasks.Clear();
                                    Console.WriteLine("Todas as tarefas foram removidas!");
                                }

                                break;
                            default:
                                Console.WriteLine("Digite 1 ou 2!");
                                break;
                        }

                    }
                    while (optRemTask != 1 && optRemTask != 2);

                    break;
                case 4:
                    contProgram = false;
                    break;
                default:
                    Console.WriteLine("Digite apenas um número de 1 a 4!");
                    break;
            }
        }
        while (contProgram);
    }
}