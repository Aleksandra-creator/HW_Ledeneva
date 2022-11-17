// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  Реализовать через функции.

int[] CreateArray(int lenght = 8)
{
    int[] tempArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        tempArray[i] = new Random().Next(0, 100);
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
Console.Write($"Случайный массив: ");
PrintArray(intArray: CreateArray());
