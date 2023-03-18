// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

string Prompt(string message="")
{
    if (!String.IsNullOrEmpty(message)) Console.Write(message);
    return Console.ReadLine();
}

int AkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AkermanFunction(n - 1, 1);
    else return AkermanFunction(n - 1, AkermanFunction(n, m - 1));
}

string input;
int n, m;

while (true)
{
    Console.WriteLine("Enter \"q\" to quit.");
    input = Prompt("Enter space separated arguments for Akerman function. n m: ");
    if (input == "q") break;
    
    string[] InputArray = input.Split(" ").ToArray();
    n = Convert.ToInt32(InputArray[0]);
    m = Convert.ToInt32(InputArray[1]);

    Console.WriteLine($"AkermanFunction({n}, {m}) = {AkermanFunction(n, m)}");
}