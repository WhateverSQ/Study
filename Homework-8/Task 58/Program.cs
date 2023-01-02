// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System.Runtime.InteropServices;

System.Console.Write("Введите количество строк 1-го массива: ");
int firstArrStrings = ReadInt();
System.Console.Write("Введите количество столбцов 1-го массива и строк 2-го массива: ");
int firstArrColumns = ReadInt();
System.Console.Write("Введите количество столбцов 2-го массива: ");
int secondArrColumns = ReadInt();

int [,] firstArray = new int[firstArrStrings, firstArrColumns];
GetRandom2Array(firstArray);
System.Console.WriteLine($"\nПервый массив:");
PrintArray(firstArray);

int [,] secondArray = new int[firstArrColumns, secondArrColumns];
GetRandom2Array(secondArray);
System.Console.WriteLine($"\nВторой массив:");
PrintArray(secondArray);

int [,] resultArray = new int[firstArrStrings, secondArrColumns];

TwoArrayMul(firstArray, secondArray, resultArray);
System.Console.WriteLine($"\nПроизведение матриц:");
PrintArray(resultArray);

void GetRandom2Array (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void TwoArrayMul (int [,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}