Console.Write($"Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
double[,] FillArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 10 - 1;
        }
    }
    return array;
}
double[,] PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(array[i, j], 1);
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
FillArray(array);
PrintArray(array);