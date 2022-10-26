// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int N = Prompt("Введите любое число: ");

if (N < 1)
{
    Console.WriteLine ($"Некорректное число. Пожалуйста, введите число от 1");
}

for (int count = 1; count <= N; count++)
{
    int res = (count * count * count);
    Console.WriteLine (res);
}
