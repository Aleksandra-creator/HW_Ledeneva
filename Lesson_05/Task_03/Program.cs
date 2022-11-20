// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int lenght)
{
    int[] tempArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        tempArray[i] = new Random().Next(1, 21);
    }
    return tempArray;
}

void PrintArray (int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write($", {intArray[i]}");
    }
}

int MaxInArray (int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinInArray (int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int DifNumber (int[] array)
{
    int max = MaxInArray(array);
    int min = MinInArray(array);
    int res = max - min;
    return res;
}

int[] array = CreateArray(6);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между минимальным и максимальным значениями равна {DifNumber(array)}");

