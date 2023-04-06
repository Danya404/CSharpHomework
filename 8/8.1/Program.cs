//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 
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

void DescendingOrder(int[,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] array = new int[matrix.GetLength(0)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }
        int temp;
        for (int comparedNum = 0; comparedNum < array.Length - 1; comparedNum++)
        {
            for (int comparableNum = comparedNum + 1; comparableNum < array.Length; comparableNum++)
            {
                if(array[comparedNum] < array[comparableNum])
                {
                    temp = array[comparedNum];
                    array[comparedNum] = array[comparableNum];
                    array[comparableNum] = temp;

                }
            }
            
        }
        // честно говоря, не понял зачем эти игры в пятнашки, если мы на уроке разобрали метод Array.Sort и весь предыдущий цикл укладывается в 2 строки:
        // Array.Sort(array);
        // Array.Reverse(array);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = array[j];
        }
    } 
}

int[,] array2d = CreateMatrix(4, 4, 1, 10);
PrintMatrix(array2d);
DescendingOrder(array2d);
Console.WriteLine();
PrintMatrix(array2d);
