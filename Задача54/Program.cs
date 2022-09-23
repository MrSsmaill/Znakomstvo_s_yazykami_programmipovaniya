int[,] FillArray2(int line, int col, int min, int max)
{
    int[,] matr = new int[line, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

void PrintArray2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void BubbleSort(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                int max = matr[i, n];
                if (max < matr[i, j])
                {
                    matr[i, n] = matr[i, j];
                    matr[i, j] = max;
                }
            }
        }

    }

}



int[,] matrix = FillArray2(10, 10, -99, 999);
PrintArray2(matrix);
BubbleSort(matrix);
PrintArray2(matrix);
