// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18


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

bool IsPossibleToMultiply(int[,] matrix1, int[,] matrix2)
{
    return (matrix1.GetLength(1) == matrix2.GetLength(0));
}

int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    if (!IsPossibleToMultiply(matrix1, matrix2))
    {
        throw new Exception("Multiplication is not possible for matrixes with these dimensions.");
    }
    int[,] ResMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i=0; i<matrix1.GetLength(0); i++)
    {
        for (int j=0; j<matrix2.GetLength(1); j++)
        {
            ResMatrix[i,j] = 0;
            for (int k=0; k<matrix1.GetLength(1); k++)
            {
                ResMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return ResMatrix;
}



int[,] MyMatrix1 = 
{
    {2, 4},
    {3, 2}
};

int[,] MyMatrix2 = 
{
    {3, 4},
    {3, 3}
};

Console.WriteLine("MyMatrix1:");
PrintMatrix(MyMatrix1);
Console.WriteLine();

Console.WriteLine("MyMatrix2:");
PrintMatrix(MyMatrix2);
Console.WriteLine();

// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Result of MyMatrix1 and MyMatrix2 multiplication:");
PrintMatrix(MultiplyMatrixes(MyMatrix1, MyMatrix2));