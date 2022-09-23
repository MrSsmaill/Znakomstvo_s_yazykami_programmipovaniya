Console.Write("Ввидите число ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
string otv = " ";
while (i <= n)
{
    double sqr = Math.Pow(i,3);
    otv = otv + Convert.ToString(sqr) + ",";
    i++;
}

Console.Write(otv.Remove(otv.Length-1));