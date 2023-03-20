/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumdigits = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sumdigits}");

int SumDigits(int num)
{
    int result = 0;
    while (num != 0)
        {
            int digit = num%10;
            num /= 10;
            result += digit;
        }
    return result;
}