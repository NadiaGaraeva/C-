﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Ведите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вторая цифра числа {num}: {num / 10 % 10}");

