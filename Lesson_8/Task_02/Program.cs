// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumOfStringElements(int[,] matrix)
{
    int[] SumElements = new int [matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов {i+1}-й строки равна {sum}");
    }
    return SumElements;
}

int NumberOfString (int[] array)
{
    int MinSum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] <= array[MinSum])
        {
            MinSum = i;
        }
    }
    return MinSum;
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

int[] PrintNewArray (int[] array)
{
    Console.Write($"{array[0]} ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}
void Main()
{
    int rows = 4;
    int cols = 6;
    int[,] baseArray = CreatArray(rows, cols);
    PrintArray(baseArray);
    Console.WriteLine();
    int[] NewArray = SumOfStringElements(baseArray);
    PrintNewArray(NewArray);
    int NumString = NumberOfString(NewArray);
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой элементов - {NumString}");
}

Main();

