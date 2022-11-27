// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
        Console.WriteLine("\n");
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

double[] ArithmeticalOfColums (int[,] array)
{
    double[] arithmetical = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arithmetical[j] += array [i, j];
        }
    arithmetical[j] = arithmetical[j] / array.GetLength(0); 
    }
    return arithmetical;
}

void PrintArithmeticalOfColums (double[] arrNums)
{
    for (int i = 0; i < arrNums.Length; i++)
    {
        Console.Write($"{arrNums[i]} \n");
    }
}

int m = Prompt("Введите количество строк массива: ");
int n = Prompt("Введите количество столбцов массива: ");
Console.WriteLine();
int[,] matrix = FillArray(m, n);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"среднее арифметическое по каждому столбцу: ");
PrintArithmeticalOfColums(ArithmeticalOfColums(matrix) );


