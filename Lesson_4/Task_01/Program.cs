// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Реализовать через функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int PowerNumber (int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

int numberA = Prompt ("Введите первое число: ");
int numberB = Prompt ("Введите второе число: ");
Console.WriteLine($"При возведении первого числа в степень второго получим {PowerNumber(numberA, numberB)}");
