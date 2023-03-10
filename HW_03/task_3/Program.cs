// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int[] GetCube(int N) {
    int[] CubeArray = new int[N];
    for (int i=1; i <= N; i++) {
        CubeArray[i-1] = Convert.ToInt32(Math.Pow(i, 3));
    }
    return CubeArray;
}

int[] res1 = GetCube(3);
// Вывод результата
foreach (var number in res1) Console.Write($"{number} ");
Console.WriteLine();


int[] res2 = GetCube(5);
// Вывод результата
foreach (var number in res2) Console.Write($"{number} ");
Console.WriteLine();