//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{

    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}

void MatrixCheck (int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(0) != matrix2.GetLength(1)) Console.WriteLine("Количество строк первой матрицы не равно количеству столбцов второй матрицы. Умножение невозможно.");
    else 
    {
        MatrixMultiplication(matrix1, matrix2);
        PrintMatrix(MatrixMultiplication(matrix1, matrix2));
    }
}


int[,] matrix1 = CreateMatrix(3, 2, 1, 10);
PrintMatrix(matrix1);
int[,] matrix2 = CreateMatrix(2, 3, 1, 10);
PrintMatrix(matrix2);
int[,] matrix3 = CreateMatrix(3, 3, 1, 10);
PrintMatrix(matrix3);
MatrixCheck(matrix1, matrix2);
MatrixCheck(matrix2, matrix3);
