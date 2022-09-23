Console.Write("Введите k1 ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1 ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k2 ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2 ");
double b2 = double.Parse(Console.ReadLine());


string IntersectionPoint(double k1,double b1,double k2,double b2)
{
    double x, y;
    if (k1==k2&b1!=b2) return"Прямые параллельны";
    if (k1==k2&b1==b2) return"Прямые совпадают";
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    return$"Точка пересечения ({x};{y})";
}

Console.WriteLine(IntersectionPoint(k1,b1,k2,b2));