Console.Write("Введите строку элемента ");
int lineElement = int.Parse(Console.ReadLine());
Console.Write("Введите столбец элемента ");
int colElement = int.Parse(Console.ReadLine());
int line = 5; int col = 5; int m = -9; int n = 9;

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
void ElementSearch(int[,] matr, int line, int col)
{
    if (line-1 >= matr.GetLength(0) 
    || col-1 >= matr.GetLength(1)) Console.WriteLine("Элемента нет");
    else Console.WriteLine($"Элемент = {matr[line - 1, col - 1]}");
}
ElementSearch(FillArray2(line, col, m, n), lineElement, colElement);