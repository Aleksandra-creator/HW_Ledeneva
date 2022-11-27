// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        Console.Write($"{arrNums[i, 0]}");
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            Console.Write($" {arrNums[i, j]}");
        }
        Console.WriteLine("");
    }
}

int[,] FillArray(int m, int n)
{
    int[,] matr = new int [m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

void ElememtPosition(int[,] array, int rows, int cols)
{
    if (rows < array.GetLength(0) && cols < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента массива [{rows}, {cols}] равно {array[rows, cols]}");
    }
    else 
    {
       Console.WriteLine($"Заданного элемента нет в данном массиве"); 
    }
}

int m = Prompt("Введите количество строк массива: ");
int n = Prompt("Введите количество столбцов массива: ");
Console.WriteLine();
int[,] matrix = FillArray(m, n);
PrintArray(matrix);
Console.WriteLine();
int rows = Prompt("Введите значение элемента строки, которое необходимо найти: ");
int cols = Prompt("Введите значение элемента столбца, которое необходимо найти: ");
Console.WriteLine();
ElememtPosition(matrix, rows, cols);


