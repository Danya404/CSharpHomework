/* Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 > 10 || num / 100 == 0)
    Console.WriteLine("Число должно быть трехзначным!");
else
    Console.WriteLine(num / 10 % 10);