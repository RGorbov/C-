// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first number: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter first number: ");
int x2 = Convert.ToInt32(Console.ReadLine());

int max;

if (x1 >= x2) max = x1;
else max = x2;

Console.WriteLine($"Maximum number is: {max}");