// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter 3-digit number: ");
string? number = Console.ReadLine();

// Проверка что число трехзначноеё
if (number.Length != 3)
{
    throw new InvalidOperationException("Number must contain exactly 3-digits.");
}

Console.WriteLine($"2nd digit of number is: {number[1]}");

