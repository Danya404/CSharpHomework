// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Check(int num)
{
    if (num != Convert.ToDouble(num) || num < 1) Console.WriteLine("Введённое число не целое или не положительное");
    // не смог реализовать проверку на целостность числа. Если скажете, как это можно было сделать, буду крайне признателен.
    else naturalRow(num);
}

void naturalRow(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    naturalRow(num - 1);
}

Check(number);


