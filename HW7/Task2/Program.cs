Console.Write($"Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
void FillArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
Console.Write($"Введите число от 1 до 100, которое необходимо найти в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
void FindNum(int[,] array)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (a == array[i, j])
            {
                count++;
            }
        }

    }
    if (count > 0)
    {
        Console.Write($"Число ({a}) присутствует в массиве");
    }
    else
    {
        Console.Write($"Число ({a}) отсутствует в массиве");
    }
}
FindNum(array);