// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Реализовать через функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    } return result;

    Console.WriteLine (result);
}

int number = Prompt ("Enter you number: ");
Console.WriteLine($"The Sum of number is {SumNumber(number)}");

