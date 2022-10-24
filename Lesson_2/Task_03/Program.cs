//  Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine($"В числе {number} нет третьей цифры");
        return false;
    }
    return true;
}
int number = Prompt ("Введите число: ");
int newnumber = number;
if(ValidateNumber(number))
{
    while(newnumber > 1000)
    {
        newnumber = newnumber / 10;       
    }
    int thirdDigit = newnumber % 10;
    Console.WriteLine($"Третья цифра числа {number} - {thirdDigit}");
}

