// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool CheckPalindrom(string number)
{
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

Console.Write("Enter 5-digit number: ");
string number = Console.ReadLine();

Console.WriteLine($"Number is palindrom: {CheckPalindrom(number)}");

