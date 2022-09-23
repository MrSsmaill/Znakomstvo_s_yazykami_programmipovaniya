// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int size = 12;
int[] array = new int[size];
int num_min = -9;
int num_max = 9;

int[] fill_array(int size, int min, int max)
{
    int[] array_num = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array_num.Length; i++)
    {
        array_num[i] = rand.Next(min, max + 1);
    }
    return array_num;
}

void print_array(int[] array_num)
{
    string print = "";
    for (int i = 0; i < array_num.Length; i++)
    {
        print = print + array_num[i] + ", ";
    }
    Console.Write("Массив: ");
    Console.Write(print.Remove(print.Length - 2) + ".");
    Console.WriteLine();
}

void sum_number(int[] array_num)
{
    int sum = 0;
    for (int i = 1; i < array_num.Length; i = i + 2)
    {
        sum += array_num[i];
    }
    Console.WriteLine($"Сумма нечётных элементов равна {sum}");
}

array = fill_array(size, num_min, num_max);
print_array(array);
sum_number(array);