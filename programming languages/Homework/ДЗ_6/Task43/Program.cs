﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//            y = k1 * x + b1, y = k2 * x + b2;
//            значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;

if ((k1 == k2) && (b1 == b2))
    Console.WriteLine($"Прямые совпадают");
else if (k1 == k2)
    Console.WriteLine($"Прямые параллельны");
else
    Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
