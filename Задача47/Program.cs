// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите кол-во строк ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int n = int.Parse(Console.ReadLine());


double[,] FillArray2(int line, int col, int min, int max)
{
    double[,] matr = new double[line, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return matr;
}
void PrintArray2(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(Math.Round(matr[i, j], 3) + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray2(FillArray2(m, n, -9, 9));