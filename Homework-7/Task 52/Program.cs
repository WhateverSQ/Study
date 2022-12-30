// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using System.Runtime.InteropServices;
double average = 0;
int length = ReadInt();
int secondLength = ReadInt();
int [,] array = GetRandom2Array(length, secondLength);

PrintArray(array);
FindAverage(array);

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
            array[i, j] = random.Next(10);
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
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

double FindAverage (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
       {
        average += array[i, j];
        }
    average = average / array.GetLength(0);
    Console.Write($"{Math.Round(average, 2)} ");
    average = 0;
    }
    return average;
}

