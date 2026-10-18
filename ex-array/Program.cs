int[] numbers = { -52, -3, -110, -1 };

int maxNum = numbers[0];
int minNum = numbers[0];

foreach (int number in numbers)
{
    if (number > maxNum)
    {
        maxNum = number;
    }
    else if (number < minNum)
    {
        minNum = number;
    }
}
Console.WriteLine($"O maior número é: {maxNum}");
Console.WriteLine($"O menor número é: {minNum}");