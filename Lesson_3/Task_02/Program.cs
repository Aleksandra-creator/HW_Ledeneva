// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int x1= Prompt ("Введите координаты X первой точки: ");
int y1= Prompt ("Введите координаты Y первой точки: ");
int z1= Prompt ("Введите координаты Z первой точки: ");
int x2= Prompt ("Введите координаты X второй точки: ");
int y2= Prompt ("Введите координаты Y второй точки: ");
int z2= Prompt ("Введите координаты Z второй точки: ");

int X = x2 - x1;
int Y = y2 - y1;
int Z = z2 - z1;

double res = Math.Sqrt (X * X + Y * Y + Z * Z);
Console.WriteLine ($"Расстояние между координатами равно {res :f2}");

