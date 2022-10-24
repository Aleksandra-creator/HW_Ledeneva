// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Введите трехзначное число: ");

bool ValidateNumber(int number)
{
    if (number < 100 || number >=1000)
    {
        Console.WriteLine("Это число не трехзначное");
        return false;
    }
    return true;
}

if(ValidateNumber(number))
{
    while(number >=100)
    {
        number /= 10;
        int secondDigit = number % 10;
        Console.WriteLine($"Вторая цифра трехзначного числа - {secondDigit}");
    }
}
