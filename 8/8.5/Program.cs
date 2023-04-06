// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] CreateSpiralMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int start = 1;
    int i = 0;
    int j = 0;

    while (start <= size * size)
    {
        matrix[i, j] = start;
        start++;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        // алгоритм движения по матрице нашёл в интернете, признаю

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] spiralMatrix = CreateSpiralMatrix(4);
PrintMatrix(spiralMatrix);