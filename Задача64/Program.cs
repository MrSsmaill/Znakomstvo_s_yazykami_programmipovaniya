// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число M ");
int m = int.Parse(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "," + PrintNumbers(start + 1, end));
}

Console.WriteLine("''''" + PrintNumbers(n, m) + "''''");