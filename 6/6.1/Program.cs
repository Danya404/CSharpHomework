// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        
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

int PositiveCounter(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) counter += 1;   
    }
    return counter;
}

int[] array = CreateArray(5);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел в заданном наборе чисел равно {PositiveCounter(array)}");