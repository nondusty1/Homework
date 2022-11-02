Console.Write("Введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());

if (day > 7)
{
    Console.WriteLine("В неделе всего 7 дней");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это будний день");
}