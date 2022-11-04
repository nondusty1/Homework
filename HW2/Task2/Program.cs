Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (num >= 100)
{
    while (num > 999)
    {
        num /= 10;
    }
    result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}