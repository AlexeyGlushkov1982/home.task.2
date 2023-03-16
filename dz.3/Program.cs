// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
int day = int.Parse(Console.ReadLine()!);
if(day !=0 && day <= 7)
{
    if(day >= 6 && day <= 7)
    {
        Console.WriteLine("выходной ");
    }
    else
    {
        Console.WriteLine("не выходной ");
    }
}
else
{
    Console.WriteLine("такого дня нет ");
}