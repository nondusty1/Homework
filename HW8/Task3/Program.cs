Console.Write("Введите число строк 1-й матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2-й матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,] firstMartrix = new int[a, b];
int[,] secondMartrix = new int[b, c];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] matrixProduct = new int[a, c];
void MultipliedMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] matrixProduct)
{
    for (int i = 0; i < matrixProduct.GetLength(0); i++)
    {
        for (int j = 0; j < matrixProduct.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            matrixProduct[i, j] = sum;
        }
    }
}
FillArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);
FillArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMartrix);
MultipliedMatrix(firstMartrix, secondMartrix, matrixProduct);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(matrixProduct);