// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int lenght, int max, int min)
{
    int[] tempArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        tempArray[i] = new Random().Next(-10, 11);
    }
    return tempArray;
}

void PrintArray (int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        Console.Write($", {intArray[i]}");
    }
}

int SumNegativeNumber (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int lenght = 5;
int min = -9;
int max = 9;
int[] array = CreateArray(lenght, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {SumNegativeNumber(array)}");

