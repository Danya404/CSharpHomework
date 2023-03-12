/*
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 1)
    int start = 2;
    while (start < num + 1)
        {
            Console.Write($"{start}, ");
            start += 2;
        }
else if (num < 1)
    int start = 0;
    while (start > num - 1)
        {
            Console.Write($"{start}, ");
            start -= 2;
        }
else 
    Console.Write("Условием не оговорено действие программы при входном числе равному 1");