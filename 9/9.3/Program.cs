// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите первое число (число должно быть целым положительным!): ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число (число должно быть целым положительным!): ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Check(int num1, int num2)
{
    if ((num1 != Convert.ToDouble(num1) || num1 < 1) || (num2 != Convert.ToDouble(num2) || num2 < 1)) Console.WriteLine("Введённые числа не целые или не положительные");
    // не смог реализовать проверку на целостность числа. Если скажете, как это можно было сделать, буду крайне признателен.
    else Console.Write(AkkermanFunc(num1, num2));
}



int AkkermanFunc(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AkkermanFunc(n - 1, 1);
    else return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}

Check(num1, num2);