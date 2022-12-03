// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] CreatArray(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
        }
    }
    return matr;
}

int[,] ProductOfMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
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
    int rows = Prompt("Укажите количество строк первой матрицы: ");
    int cols = Prompt("Укажите количество столбцов первой матрицы: ");
    int[,] TheFirstArray = CreatArray(rows, cols);
    PrintArray(TheFirstArray);
    int rows2 = Prompt("Укажите количество строк второй матрицы: ");
    int cols2 = Prompt("Укажите количество столбцов второй матрицы: ");
    int[,] TheSecondArray = CreatArray(rows2, cols2);
    PrintArray(TheSecondArray);
    Console.WriteLine();
    int[,] ProdMatrix = ProductOfMatrix (TheFirstArray,TheSecondArray);
    Console.WriteLine($"Произведение матриц равно: ");
    PrintArray(ProdMatrix);
    
}
Main();

