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
void SortToMin(int[,] array)
{
    int x = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 1; k < n; k++)
            {
                if (array[i, k] > array[i, k - 1])
                {
                    x = array[i, k - 1];
                    array[i, k - 1] = array[i, k];
                    array[i, k] = x;
                }

            }
        }
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine("Упорядочивание массива по убыванию элементов в каждой строке");
SortToMin(array);
PrintArray(array);