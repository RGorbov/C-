// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] MyArray)
{
    foreach (var elem in MyArray)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}

int[] GenerateRandArray()
{
    int[] MyArray = new int[new Random().Next(3, 8)];
    for (int i = 0; i < MyArray.Length; i++)
    {
        MyArray[i] = new Random().Next(100, 999);
    }
    Console.Write("Generated array for you: ");
    PrintArray(MyArray);
    return MyArray;
}

int CountEvenNumbers(int[] MyArray)
{
    int EvenCount = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] % 2 == 0) EvenCount++;
    }
    return EvenCount;
}

int[] MyArray1 = GenerateRandArray();
Console.WriteLine($"There is {CountEvenNumbers(MyArray1)} even numbers in MyArray1.");