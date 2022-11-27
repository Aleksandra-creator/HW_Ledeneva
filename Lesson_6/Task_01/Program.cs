// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int lenght)
{
    int[] tempArray = new int[lenght];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Prompt ($"Enter the number {i + 1}: ");
    }
    return tempArray;
}

int PositiveNumber (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
           sum += 1; 
        }
    }
    return sum;
}

void PrintArray(int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        Console.Write($", {intArray[i]}");
    }
}

int[] MyArray = CreateArray(5);
PrintArray(MyArray);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел равно {PositiveNumber(MyArray)}");

