// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num1 = Prompt("Введите первое число: ");
int num2 = Prompt("Введите второе число: ");

if(num1 > num2)
{
    Console.Write ($"Число {num1} максимальное, а число {num2} минимальное");
}
else if(num1 < num2)
{
    Console.WriteLine($"Число {num2} максимальное, а число {num1} минимальное");
}
else if(num1 == num2)
{
    Console.WriteLine("Число {num1} равно числу {num2}");
}
