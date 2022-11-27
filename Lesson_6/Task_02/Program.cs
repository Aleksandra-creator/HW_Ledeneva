// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int b1 = Prompt("Укажете коэффициент b1: ");
int k1 = Prompt("Укажете коэффициент k1: ");
int b2 = Prompt("Укажете коэффициент b2: ");
int k2 = Prompt("Укажете коэффициент k2: ");

string Findintersection (int intB1, int intK1, int intB2, int intK2) 
{
    if (intB1==intB2 && intK1==intK2) return "Прямые совпадают";
    if (intK1==intK2) return "Прямые параллельны";
    double X =  Math.Round((double)(intB2 - intB1) / (double)(intK1 - intK2),2);
    double Y = Math.Round(intK1 * X + intB1,2); 
    return $"Прямые пересекутся в точке({X}, {Y}).";
}

Console.WriteLine();
Console.Write(Findintersection (b1, k1, b2, k2));


