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
}

int[,] FillArray2Sparal(int n)
{
    int[,] matr = new int[n, n];
    int i = 0, j = 0;
    int line =0;
    for (int k = 1; k <= matr.Length; k++)
    {
        if (matr[i, j] == 0) matr[i, j] = k;

        if (i == line && j < n - line - 1)
            ++j;
        else if (j == n - line - 1 && i < n - line - 1)
            ++i;
        else if (i == n - line - 1 && j > line)
            --j;
        else
            --i;
        if ((i == line + 1) && (j == line) && (line != n - line - 1)){
            line++;

        }    
    }
    return matr;
}

PrintArray2(FillArray2Sparal(4));