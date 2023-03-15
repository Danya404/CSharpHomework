/* 
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, соответсвующее дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 7)
    Console.WriteLine("Неверное значение!");
else {
    if (num == 6 || num == 7)
       Console.WriteLine("Да"); 
    else
        Console.WriteLine("Нет");
}

