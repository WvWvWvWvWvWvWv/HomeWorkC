﻿Console.Clear();
System.Console.WriteLine("Введите число : ");
int n  = Convert.ToInt32(Console.ReadLine());
for (int i = 1;  i <= n ; i++ )
    System.Console.WriteLine($"{i} ^ 3 = {i * i * i}");