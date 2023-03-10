// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter order number of weekday (from 0 to 7, where 0 and 7 both match to Sunday): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 0 || day > 7) {
    throw new ArgumentOutOfRangeException("Day range must be between 0 and 7");
}

if (day == 0 || day == 6 || day == 7) Console.WriteLine("Day is weekend");
else Console.WriteLine("Day is workday");