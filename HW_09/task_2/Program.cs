// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetRangeSum(int MinValue, int MaxValue)
{
    if (MinValue > MaxValue)
    {
        throw new Exception($"Min value can't be more tnan max value.");
    }
    if (MinValue == MaxValue) return MaxValue;
    else return GetRangeSum(MinValue + 1, MaxValue) + MinValue;
}

int M1 = 1, N1 = 15;
Console.WriteLine($"Sum of numbers between {M1} and {N1} is: {GetRangeSum(M1, N1)}");

int M2 = 4, N2 = 8;
Console.WriteLine($"Sum of numbers between {M2} and {N2} is: {GetRangeSum(M2, N2)}");