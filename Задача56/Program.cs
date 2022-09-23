// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] LineSum(int[,] matr)
{
    int[] array = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void MaxElement(int[] array)
{
    int max = array[0];
    int index = -1;
    for (int i = 0; i < array.Length; i++)
        if (max >= array[i])
        {
            max = array[i];
            index = i;
        }
    Console.WriteLine($"{index+1} строка");
}

int[,] matrix = FillArray2(3,3,-9,9);
PrintArray2(matrix);
MaxElement(LineSum(matrix));