﻿Console.Clear();
Console.WriteLine("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}