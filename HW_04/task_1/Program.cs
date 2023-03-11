// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter number-base A: ");
double A = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number-power B: ");
double B = Convert.ToInt32(Console.ReadLine());

double res = A; 
for (int i=1; i<B; i++) {
    res *= A;
}

Console.WriteLine($"A^B={res}");
