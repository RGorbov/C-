// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void PrintArray(double[] MyArray)
{
    foreach (var elem in MyArray)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}

double[] GenerateRandArray(double MinValue = -100, double MaxValue = 100, int ArrLen = 8)
{
    double[] MyArray = new double[ArrLen];
    for (int i = 0; i < MyArray.Length; i++)
    {
        MyArray[i] = Math.Round(
            (new Random().NextDouble()) * (MaxValue - MinValue) + MinValue
            , 2);
    }
    Console.Write("Generated array for you: ");
    PrintArray(MyArray);
    return MyArray;
}

// // Простой вариант
// double MaxMinDiff(double[] MyArray) {
//     double diff = MyArray.Max() - MyArray.Min();
//     return diff;
// }

// Вариант без использования встроенных методов Min и Max
double MaxMinDiff(double[] MyArray) {
    double min = MyArray[0];
    double max = MyArray[0];
    for (int i=1; i<MyArray.Length; i++) {
        if (MyArray[i] < min) min = MyArray[i];
        if (MyArray[i] > max) max = MyArray[i];
    }
    double diff = max - min;
    return diff;
}

double[] MyArray1 = GenerateRandArray(-200, 200, 8);
Console.WriteLine($"Difference between maximum and minimum value of MyArray1 is: {MaxMinDiff(MyArray1)}");