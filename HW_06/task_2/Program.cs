// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

string ArrayToString(double[] arr, string sep=", ") 
{
    return String.Join(sep, arr);
}

double[] GetLinearCoeff(string message = null)
{
    if (!String.IsNullOrEmpty(message))
    {
        Console.WriteLine(message);
    }
    Console.Write("k: ");
    double k = Convert.ToDouble(Console.ReadLine());

    Console.Write("b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double[] coeff = { k, b };
    return coeff;
}

double f(double x, double[] coeff)
{
    return coeff[0] * x + coeff[1];
}

bool CheckLinesParallel(double[] coeff1, double[] coeff2)
{
    if (coeff1[0] == coeff2[0]) return true;
    else return false;
}

double[] GetIntersecCoord(double[] coeff1, double[] coeff2)
{
    double X0 = (coeff2[1] - coeff1[1]) / (coeff1[0] - coeff2[0]);
    double Y0 = f(X0, coeff1);
    double[] IntersecCoord = { X0, Y0 };
    return IntersecCoord;
}

double[] coeff1 = GetLinearCoeff("Enter coefficients for line 1.");
double[] coeff2 = GetLinearCoeff("Enter coefficients for line 2.");

bool LinesParallel = CheckLinesParallel(coeff1, coeff2);
if (LinesParallel)
{
    Console.WriteLine("Lines are parallel. There is no intersection.");
} 
else 
{
    double[] IntersecCoord = GetIntersecCoord(coeff1, coeff2);
    Console.WriteLine($"Intersection poin is: ({ArrayToString(IntersecCoord)})");
}