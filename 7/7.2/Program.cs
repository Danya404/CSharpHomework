// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
Console.WriteLine("Введите номер строки: ");
int rowNumber = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер столбца: ");
int columnNumber = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    } 
}

void ElemFinder(int[,] matrix)
{
    if (rowNumber < 0 | rowNumber > matrix.GetLength(0) - 1 | columnNumber < 0 | columnNumber > matrix.GetLength(1) - 1)
        {
            Console.WriteLine("Такого элемента в массиве нет");
        }
    else
        {
            Console.WriteLine($"Значение элемента массива = {matrix[rowNumber, columnNumber]}");
        }

}

int[,] array2d = CreateMatrix(3, 4, -10, 10);
PrintMatrix(array2d);
ElemFinder(array2d);