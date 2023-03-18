// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNumbersBefore(int N)
{
    if (N <= 0)
    {
        throw new Exception("Number must be positive!");
    }

    if (N == 1) return $"{N}\n";
    else return $"{N}, {GetNumbersBefore(N-1)}";
}

int N1 = 5;
Console.Write($"Numbers before {N1}: {GetNumbersBefore(N1)}");

int N2 = 8;
Console.Write($"Numbers before {N2}: {GetNumbersBefore(N2)}");