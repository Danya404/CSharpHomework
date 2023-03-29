// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num =  rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 2);
    }
    return arr;
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void Difference(double[] arr)
{
    Array.Sort(arr);
    double max = arr[arr.Length - 1];
    double min = arr[0];
    Console.Write($"Разница максимального и минимального элементов массива равна {Math.Round(max - min, 2)}");
}

double[] array = CreateArray(10, -20, 20);
PrintArray(array);
Console.WriteLine();
Difference(array);