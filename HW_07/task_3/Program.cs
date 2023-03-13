// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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

int[,] GenerateMatrix(int rows, int columns, int MinValue = -100, int MaxValue = 101)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return matrix;
}

double[] GetColumnAvg(int[,] matrix) 
{
    int ColumnsNumber = matrix.GetLength(1);
    int RowsNumber = matrix.GetLength(0);
    double[] ColumnAvg = new double[ColumnsNumber];

    for (int column=0; column < ColumnsNumber; column++)
    {
        for (int row=0; row < RowsNumber; row++)
        {
            ColumnAvg[column] += Convert.ToDouble(matrix[row, column]) / RowsNumber;
        }
        ColumnAvg[column] = Math.Round(ColumnAvg[column], 2);
    }
    return ColumnAvg;
}

int[,] MyMatrix = GenerateMatrix(3, 4, 0, 11);
Console.WriteLine("Matrix below was generated: ");
PrintMatrix(MyMatrix);

Console.WriteLine();

Console.WriteLine("Average of columns values: ");
foreach (var element in GetColumnAvg(MyMatrix)) { Console.Write($"{element} "); }
Console.WriteLine();