Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine("Наибольшее из трех чисел - " + max);