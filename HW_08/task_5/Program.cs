// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintMatrix(string[,] matrix)
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

string[,] GenerateSpiralMatrix(int length1, int length2)
{
    string[,] matrix = new string[length1, length2];
    int MinRow = 0;
    int MaxRow = matrix.GetLength(0) - 1;
    int MinColumn = 0;
    int MaxColumn = matrix.GetLength(1) - 1;
    int value = 1;
    while (true)
    {
        for (int column = MinColumn; column <= MaxColumn; column++)
        {
            matrix[MinRow, column] = value.ToString("D2");
            value++;
        }
        if (matrix[MinRow + 1, MaxColumn] != null) break;
        MinRow++;
        
        for (int row = MinRow; row <= MaxRow; row++)
        {
            matrix[row, MaxColumn] = value.ToString("D2");
            value++;
        }
        if (matrix[MaxRow, MaxColumn-1] != null) break;
        MaxColumn--;

        for (int column = MaxColumn; column >= MinColumn; column--)
        {
            matrix[MaxRow, column] = value.ToString("D2");
            value++;
        }
        if (matrix[MaxRow - 1, MinColumn] != null) break;
        MaxRow--;
        
        for (int row = MaxRow; row >= MinRow; row--)
        {
            matrix[row, MinColumn] = value.ToString("D2");
            value++;
        }
        if (matrix[MinRow, MinColumn + 1] != null) break;
        MinColumn++;
    }
    return matrix;
}


string[,] matrix = GenerateSpiralMatrix(4, 4);
PrintMatrix(matrix);