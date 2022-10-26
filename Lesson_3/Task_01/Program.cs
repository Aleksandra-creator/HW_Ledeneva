// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Без использования строк
// 14212 -> нет
// 12821 -> да

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt ("Введите пятизначное число: ");

if (number <= 10000 || number >= 100000)
{
    Console.WriteLine ($"Число не является пятизначным");
}

while (number >= 10000 && number <= 100000)
{
    int N = (number % 10 * 10000) + (number % 100 / 10 * 1000) + (number % 1000 / 100 * 100) + (number % 10000 / 1000 * 10) + (number / 10000);
    if (number == N)
    {
        Console.WriteLine ($"Число {number} является палиндромом");
        break;
    }
    else
    {
        Console.WriteLine ($"Число {number} не является палиндромом");
        break;
    }
}

