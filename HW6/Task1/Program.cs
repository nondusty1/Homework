Console.Write($"Введите количество элементов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
void FillArray(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int FindingPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
FillArray(m);
Console.WriteLine($"Введено чисел больше 0: {FindingPositive(array)} ");