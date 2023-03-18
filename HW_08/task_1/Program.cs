// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void OrderMatrixRows(int[,] matrix, string by="desc")
{
    int MaxValue;
    int MaxValueColumn;
    int CurrentValue;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1)-1; column++)
        {
            MaxValueColumn = column;
            MaxValue = matrix[row, MaxValueColumn];
            CurrentValue = matrix[row, column];
            for (int i = column+1; i < matrix.GetLength(1); i++)
            {
                if (matrix[row, i] > MaxValue)
                {
                    MaxValue = matrix[row, i];
                    MaxValueColumn = i;
                }
            }
            matrix[row, column] = MaxValue;
            matrix[row, MaxValueColumn] = CurrentValue;
        }
    }
}

int[,] MyMatrix = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

PrintMatrix(MyMatrix);
Console.WriteLine();

OrderMatrixRows(MyMatrix);
PrintMatrix(MyMatrix);
Console.WriteLine();
