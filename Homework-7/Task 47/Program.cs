// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


using System.Runtime.InteropServices;
Console.Write("Введите количество строк: ");
int length = ReadInt();
Console.Write("Введите количество столбцов: ");
int secondLength = ReadInt();
double [,] array = GetRandom2Array(length, secondLength);

PrintArray(array);

int ReadInt()
{
    return int.Parse(Console.ReadLine());
}

double[,] GetRandom2Array (int length, int secondLength)
{
    double [,] array = new double [length, secondLength];
    Random random  = new Random();
    for (int m = 0; m < length; m++)
    {
        for (int n = 0; n < secondLength; n++)
        {
            array[m, n] = random.Next(1, 10) + random.NextDouble();
        }
    }
    return array;
}


void PrintArray(double [,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{Math.Round(array[m, n], 2)}, ");
        }
        Console.WriteLine();
    }
}

