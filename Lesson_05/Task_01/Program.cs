// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int lenght, int max, int min)
{
    int[] tempArray = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        tempArray[i] = new Random().Next(100, 1000);
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

int DigitNumber (int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int lenght = 4;
int min = 100;
int max = 1000;
int[] array = CreateArray(lenght, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел равно: {DigitNumber(array)}");
