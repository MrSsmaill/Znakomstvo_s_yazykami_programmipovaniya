Console.Write("Введите число A ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B ");
int numB = int.Parse(Console.ReadLine());

void pow(int num_a, int num_b)
{
    int prod = 1;
    for (int i = 0; i < num_b; i++)
    {
        prod = prod * num_a;
    }
    Console.WriteLine(prod);
}

pow(numA, numB);