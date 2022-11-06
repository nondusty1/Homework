Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int mod = 0;
int temp = 0;
for (temp = num; num != 0; num /= 10)
{
    mod = num % 10;
    sum = sum * 10 + mod;
}
if (temp == sum)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}