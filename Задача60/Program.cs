int[,,] FillArray3(int line, int col, int height, int min, int max)
{
    int[,,] matr = new int[line, col, height];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int n = 0; n < matr.GetLength(2); n++)
            {
                matr[i, j, n] = new Random().Next(min, max + 1);
            }
        }
    }
    return matr;
}

void PrintArray3(int[,,] matr)
{
    for (int n = 0; n < matr.GetLength(0); n++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int i = 0; i < matr.GetLength(2); i++)
            {
                Console.Write($"{matr[i, j, n]}({i},{j},{n}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintArray3(FillArray3(3, 3, 3, 10, 99));
