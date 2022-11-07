Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int b, int n)
{
    int result = 1;
    for (int i = 0; i < n; i++)
    {
        result *= b;
    }
    return result;
}
Console.WriteLine(Exponentiation(b, n));