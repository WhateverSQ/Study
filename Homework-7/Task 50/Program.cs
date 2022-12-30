// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System.Runtime.InteropServices;

Console.Write("Введите количество строк: ");
int length = ReadInt();
Console.Write("Введите количество столбцов: ");
int secondLength = ReadInt();
Console.Write("Введите pos1: ");
int pos1 = ReadInt();
Console.Write("Введите pos2: ");
int pos2 = ReadInt();
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

bool FindValue (int[,] array, int pos1, int pos2)
{
    if (pos1 > 0 && pos2 > 0 && pos1 < array.GetLength(0) && pos2 < array.GetLength(1))
    {
        return true;
    }
    return false;
}

if (FindValue(array, pos1, pos2))
{
    Console.WriteLine($"Число: {array[pos1, pos2]}");
}
else
{
    System.Console.WriteLine("Нет такого");
}