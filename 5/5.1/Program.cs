//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void EvenElements (int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) counter += 1;
    }
    Console.Write($"Количество четных элементов в массиве - {counter}");
}


int[] array = CreateArray(10, -999, 999);
PrintArray(array);
EvenElements(array);