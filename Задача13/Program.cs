// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

int i = 0;
num = Math.Abs(num);

if (num < 100) 
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (i < num)
    {
        if (num < 999)
        {
            break;
        }
        else
        {
            num = num/(10);
            i++;
        } 
    }
    int result = num % 10;
    Console.WriteLine($"Третья цифра = {result}");
}