// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

void PrintArray(int[] arr, string? message = null)
{
    if (!String.IsNullOrEmpty(message)) Console.Write(message);
    foreach (var elem in arr)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}

int[] MakeArray(int M)
{
    int[] arr = new int[M];
    for (int i = 0; i < arr.Length; i++)
    {
        while (true)
        {
            try
            {
                Console.Write($"Enter {i + 1} element of array: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Element must be number. Try again.");
            }
        }
    }
    return arr;
}

int CountPositiveElements(int[] arr)
{
    int CountPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) CountPositive++;
    }
    return CountPositive;
}

// 0, 7, 8, -2, -2 -> 2
int[] MyArray1 = MakeArray(5);
PrintArray(MyArray1, "Put given numbers into MyArray1: ");
Console.WriteLine($"There were {CountPositiveElements(MyArray1)} positive numbers given.");

Console.WriteLine();

// 1, -7, 567, 89, 223-> 4
int[] MyArray2 = MakeArray(5);
PrintArray(MyArray2, "Put given numbers into MyArray2: ");
Console.WriteLine($"There were {CountPositiveElements(MyArray2)} positive numbers given.");