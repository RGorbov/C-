// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void PrintArray(int[] MyArray) {
    foreach (var elem in MyArray)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}

int[] GenerateRandArray() {
    int[] MyArray = new int[new Random().Next(1,8)];
    for (int i=0; i < MyArray.Length; i++) {
        MyArray[i] = new Random().Next(-100, 100);
    }
    Console.Write("Generated array for you: ");
    PrintArray(MyArray);
    return MyArray;
}

int CountOddPosNumbers(int[] MyArray) {
    int NumSum = 0;
    for (int i=0; i<MyArray.Length; i++) { 
        if (i % 2 != 0) NumSum += MyArray[i];
    }
    return NumSum;
}

int[] MyArray1 = GenerateRandArray();
Console.WriteLine($"Sum of numbers at odd position is: {CountOddPosNumbers(MyArray1)}");