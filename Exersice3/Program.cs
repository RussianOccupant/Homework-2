// Напишите программу, которая принмает на вход цифру
// обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num > 7 || num <= 0)
{
    Console.WriteLine($"Введенная вами цифра ({num}) не соответствует порядковому номеру дня недели");
}
else
{
    if (num == 7 || num == 6)
    {
        Console.WriteLine($"{num} -> YES");
    }
    else 
    {
        Console.WriteLine($"{num} -> NO");
    }
}