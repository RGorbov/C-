// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

char[] delimiterChars = { ' ', ',' };

Console.Write("Enter three space separated digits: ");
int[] numbers = (
    Console
        .ReadLine()
        .Split(delimiterChars)
        .Where(x => !string.IsNullOrEmpty(x))
        .Select(int.Parse)
        .ToArray());

if (numbers.Length != 3)
{
    throw new InvalidOperationException("Exactly three digits must me entered.");
}

// Вывод списка чисел
foreach (var number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

int max = numbers[0];
for (int i = 1; i < 3; i++)
{
    if (numbers[i] > max) max = numbers[i];
}

Console.WriteLine($"Maximum value is: {max}");