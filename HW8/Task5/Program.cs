Console.Write("Введите размер квадратного массива - сторона A: ");
int a = Convert.ToInt32(Console.ReadLine());
int[,] squareArray = new int[a, a];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= a * a)
{
    squareArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < a - 1)
        j++;
    else if (i < j && i + j >= a - 1)
        i++;
    else if (i >= j && i + j > a - 1)
        j--;
    else
        i--;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < a; j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"{array[i,j],3} ");
            else Console.Write($"{array[i,j],3} ");
        }
        Console.WriteLine();
    }
}
PrintArray(squareArray);