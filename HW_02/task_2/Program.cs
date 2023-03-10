// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter number: ");
string? number = Console.ReadLine();

if (number.Length >= 3) {
    Console.WriteLine($"3d digit of number is: {number[2]}");
} 
else {
    Console.WriteLine($"There is no 3d digit in number");
}


