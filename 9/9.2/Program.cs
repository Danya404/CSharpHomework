//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите нижнюю границу (число должно быть целым положительным!): ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу (число должно быть целым положительным!): ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Check(int num1, int num2)
{
    if ((num1 != Convert.ToDouble(num1) || num1 < 1) || (num2 != Convert.ToDouble(num2) || num2 < 1)) Console.WriteLine("Введённые числа не целые или не положительные");
    // не смог реализовать проверку на целостность числа. Если скажете, как это можно было сделать, буду крайне признателен.
    else 
    {
        if (num1 > num2)
        {
        int temp;
        temp = num2;
        num2 = num1;
        num1 = temp;
        }
        Console.Write(naturalRowSum(num1 - 1, num2));  // Знаю, выглядит как костыль, но я не смог придумать как реализовать по-другому, ибо если взять начало с первого числа,
                                                    // то функция не возьмёт его в расчёт.
    }
}

int naturalRowSum(int num1, int num2)
{
    int sum = num1;

    if (num1 == num2) return 0; // выход из рекурсии
    else
    {
        num1++;
        sum = num1 + naturalRowSum(num1, num2);
        return sum;
    }
}

Check(num1, num2);