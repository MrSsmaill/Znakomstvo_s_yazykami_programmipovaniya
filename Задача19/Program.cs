Console.Write("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());

int num1, num2, num3, num4;

num1 = num / 1000;
num2 = num % 100 / 10; 
num3 = num % 10;
num4 = num3 * 10 + num2; 

if (num1 == num4)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}