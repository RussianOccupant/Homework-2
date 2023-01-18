// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру данного числа
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int a = num / 100;
int b = num % 10;
int c = (num - a * 100 - b) / 10;

Console.WriteLine($"{num} -> {c}");
