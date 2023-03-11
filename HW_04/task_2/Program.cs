// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumberDigits(int number) {
    int SumDigits = number
        .ToString()
        .Select(x => Convert.ToInt32(x.ToString()))
        .ToArray()
        .Sum();
        
    return SumDigits;
}

// 452 -> 11
Console.WriteLine($"Sum of number digits is: {SumNumberDigits(452)}");

// 82 -> 10
Console.WriteLine($"Sum of number digits is: {SumNumberDigits(82)}");

// 9012 -> 12
Console.WriteLine($"Sum of number digits is: {SumNumberDigits(9012)}");