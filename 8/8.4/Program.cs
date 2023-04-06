// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

void SizeCheck(int[,,] matrix)
{
    if ((matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)) >= 100) Console.WriteLine("Слишком большая матрица!");
    else PrintMatrixByRows(matrix);
}



int[,,] Create3DMatrix(int lenght, int widht, int height)
{

    int[] perm = Enumerable.Range(10, 90).ToArray();
    int[,,] matrix = new int[lenght, widht, height];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = perm[rnd.Next(0, perm.Length - 1)];
            }

        }
    }
    return matrix;
}

void PrintMatrixByRows(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }

    }
    Console.WriteLine();
}

int[,,] matrix1 = Create3DMatrix(2, 2, 2);
SizeCheck(matrix1);
Console.WriteLine();
int[,,] matrix2 = Create3DMatrix(5, 4, 5);
SizeCheck(matrix2);