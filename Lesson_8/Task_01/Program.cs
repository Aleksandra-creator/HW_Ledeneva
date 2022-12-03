// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] CreatArray(int rows, int cols, int IntRows, int IntCols)
{
    int[,] matr = new int[rows, cols];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(IntRows, IntCols);
        }
    }
    return matr;
}

int[,] SortMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = j;
            for (k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i,k] < matrix[i, k+1])
                {
                    (matrix[i,k], matrix[i, k+1]) = (matrix[i, k+1], matrix[i,k]);
                }
            }
        }
    }
    return matrix;
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
        Console.WriteLine("\n");
    }
}

void Main()
{
    int rows = Prompt("Укажите количество строк: ");
    int cols = Prompt("Укажите количество столбцов: ");
    int IntRows = Prompt("Укажите лимит элементов: ");
    int IntCols = Prompt("Укажите лимит элементов: ");
    int[,] baseArray = CreatArray(rows, cols, IntRows, IntCols);
    PrintArray(baseArray);
    Console.WriteLine();
    int[,] PrintMatrix = SortMatrix(baseArray);
    PrintArray(PrintMatrix);
}

Main();

