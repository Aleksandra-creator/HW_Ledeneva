// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int value = Prompt("Введите натуральное число: ");
int number = 2;

if(value <= 1 && value % 2 != 0)
{
    value = Prompt("Введите натуральное число: ");
}
else
{
    while(value >= number)
    {
        Console.Write($"{number} ");
        number = number + 2;
    }
}