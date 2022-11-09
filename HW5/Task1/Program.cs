int[] array = new int[5];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int EvenNums(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            num++;
        }
    }
    return num;
}
FillArray(array);
PrintArray(array);
int num = EvenNums(array);
Console.WriteLine($"Количество чётных чисел в массиве: {num}");