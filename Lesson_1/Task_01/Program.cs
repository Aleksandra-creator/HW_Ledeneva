// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

int num1 = 5;
int num2 = 7;

if(num1 > num2)
{
    Console.WriteLine($"Число {num1} максимальное, а число {num2} минимальное");
}
else if(num1 < num2)
{
    Console.WriteLine($"Число {num2} максимальное, а число {num1} минимальное");
}
else
{
    Console.WriteLine("Число {num1} равно числу {num2}");
}
