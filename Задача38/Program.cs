///// Настройка////
int size = 12;
double[] array = new double[size];
int num_min = 1;
int num_max = 99;

double[] fill_array(int size, int min, int max)
{
    double[] array_num = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array_num.Length; i++)
    {
        array_num[i] =Math.Round(rand.NextDouble(min, max + 1),2);
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

void max_min_array(double[] array_num,int size)
{
    int max_value=0;
    int min_value=size;
    foreach (int value in array_num)
    {
        if (value > max_value) max_value = value;
        else
        {
            if (value < min_value) min_value = value;
        }
    }
    Console.WriteLine($"Разница между максимальным ({max_value}) и минимальным ({min_value}) элементом массива равен {max_value - min_value}");
}

array = fill_array(size, num_min, num_max);
print_array(array);
max_min_array(array,size);