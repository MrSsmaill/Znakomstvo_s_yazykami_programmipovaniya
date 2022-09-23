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