//  Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
using System.Runtime.InteropServices;
int sum = 0;
int length = ReadInt();
int secondLength = ReadInt();
int [,] array = GetRandom2Array(length, secondLength);

PrintArray(array);
FindSumDiag(array);
System.Console.WriteLine();
System.Console.WriteLine($"Sum is: {sum}");



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

int FindSumDiag(int[,] array)
{   
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}