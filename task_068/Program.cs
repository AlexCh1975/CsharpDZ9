/*
    Задача 68: Напишите программу вычисления функции Аккермана 
    с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
    m = 2, n = 3 -> A(m,n) = 29
*/

Console.Clear();

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermanFunction(m, n);
PrintResult(result);

int AckermanFunction(int m, int n)
{
    if (m > 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
         return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
    else return n + 1;
}

void PrintResult(int result)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"A({m}, {n}) -> {result}");
    Console.ResetColor();
}