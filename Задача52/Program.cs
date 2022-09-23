// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int line = 3; int col = 3; int m = -9; int n = 9;

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
}

void Average(int[,] matr)
{
    string average=String.Empty;
    int amount = matr.GetLength(0);
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum+=matr[j, i];
        }
        sum /=amount;
        average = average +Math.Round(sum,1) + "; " + "\t";
    }
    Console.WriteLine("Cреднее арифметическое элементов в каждом столбце равно");
    Console.WriteLine(average);
}

int[,] matrix = FillArray2(line,col,m,n);
PrintArray2(matrix);
Console.WriteLine();
Average(matrix);