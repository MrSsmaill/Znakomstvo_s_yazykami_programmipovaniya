// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void PrintArray2(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MatrixProduct(double[,] matr1, double[,] matr2)
{
    double[,] sumMatr = new double[matr1.GetLength(0), matr1.GetLength(0)];
    for (int i = 0; i < sumMatr.GetLength(0); i++)
    {
        for (int j = 0; j < sumMatr.GetLength(1); j++)
        {
            for (int k = 0; k < sumMatr.GetLength(0); k++)
            {
                sumMatr[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return sumMatr;
}

double[,] matrix1 = { { 2, 4 }, { 3, 2 } };
double[,] matrix2 = { { 3, 4 }, { 3, 3 } };
PrintArray2(matrix1);
PrintArray2(matrix2);
double[,] matrixSum = MatrixProduct(matrix1, matrix2);
PrintArray2(matrixSum);