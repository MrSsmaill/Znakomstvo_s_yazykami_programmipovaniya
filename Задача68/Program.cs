Console.Write("Введите число n: ");
UInt64 n = Convert.ToUInt64(Console.ReadLine());
Console.Write("Введите число m: ");
UInt64 m = Convert.ToUInt64(Console.ReadLine());

UInt64 AckermannFunc(UInt64 m, UInt64 n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}

Console.WriteLine(AckermannFunc(m, n));


