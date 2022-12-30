// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

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
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = i + j;
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

