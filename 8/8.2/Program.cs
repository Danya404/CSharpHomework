// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

int LessSumRow(int[,] matrix)
{
    double lessSum = double.PositiveInfinity;
    int rowNumber = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp+= matrix[i, j];
        }
        if (temp < lessSum)
        {
            lessSum = temp;
            rowNumber = i+1;
        }
    } 
    return rowNumber;
}


int[,] array2d = CreateMatrix(4, 4, 1, 10);
PrintMatrix(array2d);
int lessSumRowNumber = LessSumRow(array2d);
Console.Write($"Cтрока с наименьшей суммой элементов: {lessSumRowNumber} строка");