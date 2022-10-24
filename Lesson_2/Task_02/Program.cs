// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число - {number}");

int firstDigit = number % 10;
int secondDigit = number / 100;
int result = secondDigit * 10 + firstDigit;
Console.WriteLine($"После удаления второй цифры получаем число - {result}");

