/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите желаемую степень числа: ");
int pow = Convert.ToInt32(Console.ReadLine());
if (pow < 0) pow = -pow;
int power = Power(number, pow);
Console.WriteLine($"{number} в степени {pow} равняется {power}");

int Power(int num, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
        result *= num;
    return result;
}