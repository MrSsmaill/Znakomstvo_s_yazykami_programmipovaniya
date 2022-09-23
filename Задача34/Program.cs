int size = 12;
int[] array = new int[size];
int num_min = 100;
int num_max = 999;
int value = 4;

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

void number_values(int[] array_num, int value)
{
    int num_value = 0;
    foreach (int item in array_num)
    {
        int variable = item;
        while (variable != 0)
        {
            int remainder = variable % 10;
            variable = variable / 10;
            if (remainder == value) num_value++;
        }
    }
    Console.WriteLine($"Количество чисел {value} в массиве равно {num_value}");
}

array = fill_array(size, num_min, num_max);
print_array(array);
number_values(array, value);