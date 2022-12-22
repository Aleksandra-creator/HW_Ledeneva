// Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenNumbers (int n, int m)
{
    for (int i = n; i <= m; i++)
        {
            if (m > n && i % 2 == 0) 
            {
                Console.Write(i);
            }
        }
}

void Result ()
{
    int n = 1;
    int m = 8;
    Console.WriteLine(EvenNumbers(n, m));
}
Result();

// string EvenNumbers(int m, int n) 
// {
//     if (m % 2 != 0 && m < n) m += 1;
//     if (m < 0) m = 2; 
//     if (m > n) return "";
//     else return ($"{m}, " + EvenNumbers(m + 2, n)).TrimEnd(' ', ','); 
// }

// void Result() 
// {
//     int m = 1;
//     int n = 8;
//     Console.WriteLine(EvenNumbers(m, n));
// }

// Result();
