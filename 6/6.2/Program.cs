// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = 5x + 2
// y = 9x + 4
// 5x + 2 = 9x + 4
// 4x = -2
// x = -0.5
// y = 5 * -0.5 + 2
// y = -2.5 + 2
// y = -0.5

Console.WriteLine("Задача: найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2");
Console.WriteLine("Задайте значение для k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

void Equation(int a1, int d1, int a2, int d2)
{
    if (a1 == a2 && d1 == d2) Console.WriteLine("Прямые совпадают");
    else if (a1 == a2) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (double)(-d1 + d2)/(a1 - a2);
        double y = a1 * x + d1;
        Console.WriteLine(x);
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}, {y})");
    }
}

Equation(k1, b1, k2, b2);
