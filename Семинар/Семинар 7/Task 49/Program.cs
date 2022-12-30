// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

using System.Runtime.InteropServices;

int length = ReadInt();
int secondLength = ReadInt();
int [,] array = GetRandom2Array(length, secondLength);

PrintArray(array);
ChangeToPow(array);
System.Console.WriteLine();
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeToPow(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
            }
        }
    }
}