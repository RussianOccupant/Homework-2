// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = num / 100;
int b = a % 10;
if (a == 0)
{
    Console.WriteLine($"{num} -> третьей цифры нет!");
}
else
{
    Console.WriteLine($"{num} -> {b}");
}
