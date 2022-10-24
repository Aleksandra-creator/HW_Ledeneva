// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int day = Prompt ("Введите цифру, обозначающую день недели: ");
if (day >= 1 && day <= 5)
{
   Console.WriteLine ($"Этот день не является выходным");
}
else if (day >=6 && day <= 7)
{
    Console.WriteLine ($"Этот день является выходным");
}
else
{
    Console.WriteLine ($"Такого дня недели не существует");
}

