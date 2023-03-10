// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void CheckVector(double[] A)
{
    if (A.Length != 3)
    {
        throw new IndexOutOfRangeException($"Vector must contain 3 coordinates. {A.Length} was gotten.");
    }
}

double GetDistance(double[] A, double[] B)
{
    CheckVector(A);
    CheckVector(B);

    double X_A = A[0], Y_A = A[1], Z_A = A[2];
    double X_B = B[0], Y_B = B[1], Z_B = B[2];
    double distance = Math.Round(
        Math.Sqrt(Math.Pow(X_A - X_B, 2) + Math.Pow(Y_A - Y_B, 2) + Math.Pow(Z_A - Z_B, 2)), 2);
    return distance;
}

// A (3,6,8); B (2,1,-7), -> 15.84
// Сделать вывод векторов
Console.WriteLine($"Distance is: {GetDistance(new double[] { 3, 6, 8 }, new double[] { 2, 1, -7 })}");

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine($"Distance is: {GetDistance(new double[] { 7, -5, 0 }, new double[] { 1, -1, 9 })}");