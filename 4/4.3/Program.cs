/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

int[] array = new int[8];
RandArray(array);
PrintArray(array);
void RandArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}