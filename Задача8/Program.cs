﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int i = 2;
while (i <= num)
{
    Console.Write($"{i}, ");
    i = i+2;
}