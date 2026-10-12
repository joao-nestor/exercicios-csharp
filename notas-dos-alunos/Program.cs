namespace notas_dos_alunos;

public class Program
{
    public static void Main()
    {
        double[] grades = new double[5];
        bool Continue = true;
        string contMessage = "";

        do
        {
            double sumOfTheScores = 0;
            int approved = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Digite a nota do aluno {i + 1}: ");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach (double grade in grades)
            {
                if (grade >= 7)
                {
                    approved++;
                }

            }

            foreach (double grade in grades)
            {
                sumOfTheScores += grade;
            }

            Console.Write($"Notas: {grades[0]}, {grades[1]}, {grades[2]}, {grades[3]}, {grades[4]}");
            Console.WriteLine($"\nMédia: {sumOfTheScores / grades.Length} ");
            Console.WriteLine($"Alunos aprovados: {approved}");

            do
            {
                Console.WriteLine("Quer continuar?");
                contMessage = Console.ReadLine();

                switch (contMessage)
                {
                    case "s":
                    case "S":
                        Continue = true;
                        break;
                    case "n":
                    case "N":
                        Continue = false;
                        Console.WriteLine("Obrigado por usar o sistema!");
                        break;
                    default:
                        Console.WriteLine("Digite sim ou não!");
                        break;
                }
            }
            while (contMessage != "s" && contMessage != "S" && contMessage != "n" && contMessage != "N");
        }
        while (Continue);

    }
}