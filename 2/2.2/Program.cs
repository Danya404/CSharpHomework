/* Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string str_num = Convert.ToString(num);
if (num / 100 < 1)
    Console.WriteLine("Число должно быть трехзначным или больше!");
else
    Console.WriteLine($"Третья цифра числа -> {str_num[2]}");