/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

Console.WriteLine("Введите число: ");
int num_to_cube = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int count = 1;
    while(count <= num)
    {
        int cube = count*count*count;
        Console.WriteLine($"{count} -> {cube}");
        count++;
    }

}

Cube(num_to_cube);