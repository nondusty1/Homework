Console.Write($"Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
void PrintNumber(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        PrintNumber(n, count + 1);
        Console.Write(count + ", ");
    }
}
PrintNumber(n, count);
Console.Write(1);