// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N 
// с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumOfNumbers(int m, int n) 
{
    if (m < 0) m = 1;
    if (m > n) return 0; 
    else return (m + SumOfNumbers(m + 1, n));
}

void Result() 
{
    int m = 4;
    int n = 8;
    Console.WriteLine(SumOfNumbers(m, n));
}

Result();