// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

using System.Runtime.InteropServices;

int length = ReadInt();
int secondLength = ReadInt();
int [,] array = GetRandom2Array(length, secondLength);

PrintArray(array);

int ReadInt()
{
    return int.Parse(Console.ReadLine());
}

int[,] GetRandom2Array (int length, int secondLength)
{
    int [,] array = new int [length, secondLength];
    Random random  = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(1000);
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }
}