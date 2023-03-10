// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenerateArray(int ArrayLength) {
    int[] MyArray = new int[ArrayLength];
    Console.WriteLine("Start writing to MyArray (Info just to check out): ");
    for (int i=0; i<MyArray.Length; i++) {
        MyArray[i] = new Random().Next(1, 100);
        Console.Write($"{MyArray[i]} ");
    }
    Console.WriteLine();
    return MyArray;
}

void WriteArray(int[] MyArray) {
    Console.WriteLine("Printing MyArray:");
    foreach (var elem in MyArray) {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}


int[] MyArray1 = GenerateArray(8);
WriteArray(MyArray1);

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
WriteArray(new int[] {1, 2, 5, 7, 19});

// 6, 1, 33 -> [6, 1, 33]
WriteArray(new int[] {6, 1, 33});