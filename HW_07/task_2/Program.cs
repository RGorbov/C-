// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void GetElementByPosition(int[,] matrix, int position)
{
    if (position > matrix.GetLength(0) * matrix.GetLength(1))
    {
        Console.WriteLine("There is no element at this position. Out of index.");
    }
    else
    {
        int row = position / matrix.GetLength(1);
        int column = position % matrix.GetLength(1);
        Console.WriteLine($"Position: {position}. Value: {matrix[row, column]}.");
    }
}


int[,] MyArray = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

GetElementByPosition(MyArray, 3);
Console.WriteLine();
GetElementByPosition(MyArray, 17);