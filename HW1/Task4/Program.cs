﻿Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;

while (num2 < num1)
{
    num2++;
    if (num2 % 2 == 0)
    {
        Console.Write(num2 + " ");
    }
}