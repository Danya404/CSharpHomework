/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. */

Console.WriteLine("Введите координаты первой точки по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;
    double distance = Math.Sqrt(x*x+y*y+z*z);
    return distance;
}

double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(result);