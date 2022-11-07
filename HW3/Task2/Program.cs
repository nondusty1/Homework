Console.Write("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    Console.Write("{1} в кубе это {2} \n", i, i, (i * i * i));
}