Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int LumpSum(int num)
{
    int temp = 0;
    int sum = 0;
    while (num > 0)
    {
        temp = num % 10;
        sum += temp;
        num /= 10;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе: {LumpSum(num)}");