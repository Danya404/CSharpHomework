/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления). */
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (Convert.ToString(num).Length != 5) Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число: ");

string Palindrome(int num)
{
    string Temp_a = Convert.ToString(num/1000);
    int a = Convert.ToInt32(Convert.ToString(Temp_a[1]) + Convert.ToString(Temp_a[0]));
    int b = num%100;
    if (a==b) return "Ваше число - палиндром";
    else return "Ваше число - не палиндром";
}

string palindrome = Palindrome(num);
Console.WriteLine(palindrome);