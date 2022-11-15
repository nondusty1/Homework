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
            Console.Write($"{array[i, j]}" + " ");
        }
        Console.WriteLine();
    }
}
void MinSumRow(int[,] array)
{
    int minsum = 0;
    int row = 0;
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        minsum += array[0, j];
    }
    for (int i = 1; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            row = i;
        }
        else sum = 0;
    }
    Console.WriteLine($"Cтрока {row + 1} с наименьшей суммой элементов");
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
MinSumRow(array);