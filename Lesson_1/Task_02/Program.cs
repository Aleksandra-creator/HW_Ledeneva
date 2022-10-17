// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

int[] num = {2, 3, 7};
int max = num[0];

for (int i = 0; i < num.Length; i++)
{
    if(max < num[i++])
    {
        Console.WriteLine($"Число {num[i++]} максимальное");
        i = i++;
    }
    else
    {
        Console.WriteLine($"Число {max} максимальное");
    }

}
