// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = Prompt($"Введите первое число: ");
int b = Prompt($"Введите второе число: ");
int c = Prompt($"Введите третье число: ");

int max = a;
if(max < b) 
{
    max = b;
}
if (max < c) 
{
    max = c;
}
else
{
    max = a;
}
Console.WriteLine($"Максимальное число равно {max}");