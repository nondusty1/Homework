Console.Write("Введите количество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
Console.WriteLine($"Массив из {count} элементов следующий: ");
for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(1,100);
    
    Console.Write(array[i] + " ");    
}