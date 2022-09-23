// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

if (num > 7 || num <=0)
{
    Console.WriteLine("Вы ввели не правильный день недели");
}
else
{
    if (num < 6)
    {
        Console.WriteLine("Сегодня не выходной");
    }
    else
    {
        Console.WriteLine("Сегодня выходной");
    }
}