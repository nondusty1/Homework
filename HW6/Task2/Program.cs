Console.Write("Введите a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c:");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите d:");
double d = Convert.ToDouble(Console.ReadLine());

double X = (c - d) / (b - a);
double Y = b * X + d;

Console.WriteLine($"Точка пересечения двух прямых имеет координаты xy ({X};{Y})");