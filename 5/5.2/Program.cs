// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


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

void OddElementsSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 != 0) result += arr[i];
    }
    Console.Write($"Сумма элементов, стоящих на нечетных позициях равна {result}");
}


int[] array = CreateArray(10, -20, 20);
PrintArray(array);
OddElementsSum(array);