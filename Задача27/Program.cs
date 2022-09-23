// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

void SunNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    Console.WriteLine(sum);
}
SunNumber(number);