namespace calculadora_simples;

public class Program
{
    public static void Main()
    {
        bool varContinue = true;

        while (varContinue)
        {
            // Inicialização do programa

            Console.WriteLine("==========CALCULADORA SIMPLES==========\n");
            
            Console.WriteLine("Digite o primeiro número: "); // Primeiro número
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: "); // Segundo número
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Seleciona o tipo de operação

            Console.WriteLine("\nQual operação deseja fazer?");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("Digite o número da operação que deseja fazer: \n");
            int operation = Convert.ToInt32(Console.ReadLine()); // Converte para inteiro

            double result = 0; // Cria variável para resultado

            // Operações

            if (operation == 1)
            {
                result = number1 + number2;
            } 
            else if (operation == 2)
            {
                result = number1 - number2;
            }
            else if (operation == 3)
            {
                result = number1 * number2;
            }
            else if (operation == 4)
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("\nErro: não é possível dividir um número por zero!");
                }
            }
            else
            {
                Console.WriteLine("\nOperação Inválida!");
            }
            
            // Se for qualquer uma dessas operações (incluindo divisão com número dois diferente de zero), aparecerá o resultado

            if (operation == 1 || operation == 2 || operation == 3 || (operation == 4 && number2 != 0))
            {
                Console.WriteLine($"\nO resultado da conta é {result}");
            }

            // Pergunta ao usuário se quer continuar usando a calculadora

            Console.WriteLine("\nQuer continuar? (s/N)");
            string response = Console.ReadLine();

            if (response == "s" || response == "S")
            {
                varContinue = true;
            }
            else if (response == "n" || response == "N")
            {
                varContinue = false;
                Console.WriteLine("Obrigado por utilizar a calculadora!");
            }
            else
            {
                Console.WriteLine("Digite sim ou não!");
            }

        }

    }
}