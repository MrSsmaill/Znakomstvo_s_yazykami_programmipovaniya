Console.Write("Введите числа через пробел ");
string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

void AboveZero(string[] st)
{
    int count = 0;
    foreach (string value in st)
    {
        if (int.Parse(value) > 0) count++;
    }
    Console.WriteLine($"Количество чисел больше 0 равно {count}");
}

AboveZero(st);