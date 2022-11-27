// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

void PrintArray(int[,] arr, int rows, int cols)
{
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{arr[i, 0]}");
        for (int j = 1; j < cols; j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine("");
    }
}

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

int FindMinInCol (int[,] arr, int rows, int cols)
{
    int intMin = arr[0, cols];
    for (int i=0; i<rows; ++i)
    {
        if (arr[i,cols]<intMin) intMin = arr[i,cols];    
    }
    return intMin;    
}

int FindSumOfMin(int[,] arr, int rows, int cols) // Обход столбцов и поиск суммы минимальных элементов каждого столбца
{
    int intSum = 0;
    for (int j = 0; j < cols; j++)
    {
        if (j > 0) Console.Write("+");
        int temp = FindMinInCol(arr, rows, j);
        Console.Write(temp);
        intSum += temp;
    }
    Console.WriteLine($"={intSum}");
    return intSum;
}

int FindMaxInRow(int[,] arr, int row, int cols) // Поиск максимального в строке
{
    int intMax = arr[row, 0];
    for (int j = 1; j < cols; j++)
    {
        if (arr[row, j] > intMax) intMax = arr[row, j];
    }
    return intMax;
}

int FindSumOfMax(int[,] arr, int rows, int cols) // Обход строк и подсчет суммы максимальных элементов в каждой строке
{
    int intSum = 0;
    for (int i = 0; i < rows; i++)
    {
        if (i > 0) Console.Write("+");
        int temp = FindMaxInRow(arr, i, cols);
        Console.Write(temp);
        intSum += temp;
    }
    Console.WriteLine($"={intSum}");
    return intSum;
}

int[,] MyArray = new int[2, 4];
int rows = 2;
int cols = 4;
FillArray(MyArray);
PrintArray(MyArray, rows, cols);
int SumOfMax = FindSumOfMax(MyArray, rows, cols);
int SumOfMin = FindSumOfMin(MyArray, rows, cols);
Console.Write($"Сумма максимальных значений равна: ");
Console.WriteLine(SumOfMax);
Console.Write($"Сумма минимальных значений равна: ");
Console.WriteLine(SumOfMin);
Console.Write($"Разница суммы максимальных значений и суммы минимальных значений равна: ");
Console.WriteLine((SumOfMax) - (SumOfMin));


