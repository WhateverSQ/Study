// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9] Найдите сумму отрицательных и положительных элементотв массива
//int minimalSum = 0;
//int maximalSum = 0;
//int number = ReadInt("Find number");
int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 1, 5);
//int count = 0;


PrintArray(array);
//SwitchElement(array);
System.Console.Write(" / ");
//FindCount(array, count);
//PrintArray(array);
//SearchNumber(array, number);
int [] newarray = PairProduct(array);
PrintArray(newarray);


//CalculateSum(array);

//System.Console.WriteLine($"Positive sum is {maximalSum}; Negative sum is {minimalSum}");
int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

//void CalculateSum(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] < 0)
//        {
//        minimalSum += array[i];
//        }
//        else 
 //       {
 //           maximalSum += array[i];
//        }
//    }
//}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

// Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

void SwitchElement(int[] array)
{
for (int i = 0; i <array.Length; i++)
{
    array[i] = -array[i];
}
}

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

void SearchNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            System.Console.WriteLine("Yes");
            return;
        }
    }
    System.Console.WriteLine("No");
}

//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void FindCount(int [] array, int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 99)
        {
            count = count + 1;
        }
    }
    System.Console.WriteLine($"{count}");
}

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int [] PairProduct(int [] array)
{
    int[] newarray = new int[(array.Length / 2) + 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newarray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)

    newarray[array.Length / 2] = array[array.Length / 2];

    return newarray;
}
