﻿// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " чётное");
}
else
{
    Console.WriteLine("Число "+ num + " не чётное");
}