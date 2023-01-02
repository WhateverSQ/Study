// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System.Runtime.InteropServices;

System.Console.Write("Введите количество строк: ");
int length = ReadInt();
System.Console.Write("Введите количество столбцов: ");
int secondLength = ReadInt();
int [,] array = GetRandom2Array(length, secondLength);

PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Номер строки с наименьшей суммой: {FindMinSum(array)}");


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

int ReadInt()
{
    return int.Parse(Console.ReadLine());
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

int FindMinSum(int [,] array)
{
    int minSum = int.MaxValue;
    int idx = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            
        }
        System.Console.WriteLine($"Сумма строки {i} = {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            idx = i;
        }
    }
    return idx;
}

