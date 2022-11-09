double[] array = new double[5];
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
FillArray(array);
PrintArray(array);
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
    if (max < array[i])
    {
        max = array[i];
    }
}
Console.WriteLine($"Разница между {max} и {min} элементов массива {max - min}");