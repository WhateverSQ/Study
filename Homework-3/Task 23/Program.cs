﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
for (double i = 1; i <= N; i++)
{
    Console.WriteLine($"{Math.Pow(i, 3)}");
}