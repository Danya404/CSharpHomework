/*
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
    max = b;
else if (c > a)
    max = c;
Console.Write($"Наибольшее из трех чисел: {max}");