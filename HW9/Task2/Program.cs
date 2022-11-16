Console.Write($"Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
void PrintSum(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов в промежутке от M до N = {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}
PrintSum(m, n, temp = 0);