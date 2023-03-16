// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowWithMinSum(int[,] matrix)
{
    int? MinRowSum = null;
    int MinRow = 1;
    for (int row=0;row<matrix.GetLength(0); row++)
    {
        int RowSum = 0;
        for (int column=0; column<matrix.GetLength(1); column++)
        {
            RowSum += matrix[row, column];
        }
        if (MinRowSum.HasValue || row == 0) 
        {
            if (RowSum < MinRowSum || row == 0)
            {
                MinRowSum = RowSum;
                MinRow = row + 1;   
            }            
        }
    }
    return MinRow;
}

int[,] MyMatrix = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};

PrintMatrix(MyMatrix);
Console.WriteLine();

Console.WriteLine($"Row number (starts from 1, not from 0) with minimum sum of elements is: {GetRowWithMinSum(MyMatrix)}");
