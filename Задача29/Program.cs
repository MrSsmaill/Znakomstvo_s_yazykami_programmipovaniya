// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int size = 8;
int[] array = new int[size];
int num_min = 0;
int num_max = 99;
print_array(fill_array(array, num_min, num_max));

int[] fill_array(int[] array_num, int min, int max)
{
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
    return;
}