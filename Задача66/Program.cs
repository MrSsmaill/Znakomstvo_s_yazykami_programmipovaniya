﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число M ");
int m = int.Parse(Console.ReadLine());


int SumElements(int start, int end)
{
    if (start == end) return start;
    return (start + SumElements(start + 1, end));
}

Console.WriteLine($"Сумма элементов в промежутке от {n} до {m} равна {SumElements(n, m)}");