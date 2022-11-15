Console.Write("Введите размер 3D массива - сторона A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер 3D массива - сторона B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер 3D массива - сторона C: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[a, b, c];
void FillArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = new Random().Next(1, 99);
            }
        }
    }
}
void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i, j, z]} ({i},{j},{z}) \t");
            }
            Console.WriteLine();
        }
    }
}
FillArray3D(array3D);
PrintArray3D(array3D);