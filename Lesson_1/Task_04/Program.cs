// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] numbers = new int[num];

for (int i = 0; i <= numbers.Length; i++)
{
    if(num % 2 == 0 && num > 1)
    {
        Console.Write(num);
    }
   else{
    Console.Write(",");
    i = i++;
   }
}
