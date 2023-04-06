﻿//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
string f(int n)
{
    if (n == 1)
        return "1 ";
    return $"{n} " + f(n - 1);
}


Console.Clear();
System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(f(n));