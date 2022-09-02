/*
    Задача 66: Задайте значения M и N. Напишите программу, 
    которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 56
    M = 4; N = 8. -> 18
*/

//Console.Clear();

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int n = 0, m = 0;

if (numberN == numberM)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Warning! Интервал между числами равен нулю!");
    Console.ResetColor();
}
else if (numberN < numberM)
{
    m = numberN;
    n = numberM;
}
else
{
    n = numberN;
    m = numberM;
}

int[] arrayNumber = new int[n - m +1];
int sumNumber = 0;

arrayNumber = GetArrayNumber(n, m, arrayNumber);
sumNumber = GetSumNumber(arrayNumber, sumNumber);
PrintArrayNumber(arrayNumber, numberN, numberM, sumNumber);


int[] GetArrayNumber(int numberN, int numberM, int[] arrayNumber, int i = 0)
{  
    if(numberM <= numberN) 
    {
        arrayNumber[i] = numberN;
        numberN--;
        i++;
        return GetArrayNumber(numberN, numberM, arrayNumber, i);
    }
     return arrayNumber;
}

int GetSumNumber(int[] arrayNumber, int sumNumber, int i = 0)
{
    if(i < arrayNumber.Length)
    {
        if(arrayNumber[i] % 2 == 0) sumNumber += arrayNumber[i]; 
        i++;
        return GetSumNumber(arrayNumber, sumNumber, i);
    }
    return sumNumber;
}

void PrintArrayNumber(int[] arrayNumber, int numberN, int numberM, int sumNumber)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"M = {numberM}; N = {numberN} -> \" ");

    for (int i = 0; i < arrayNumber.Length; i++)
    {
        if (arrayNumber.Length -1 == i) Console.Write($"{arrayNumber[i]} ");
        else Console.Write($"{arrayNumber[i]}, ");
    }

    Console.WriteLine($"\"    Сумма чисел в интервале = {sumNumber}");
    Console.ResetColor();
}
