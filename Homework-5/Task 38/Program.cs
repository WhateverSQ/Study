// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76
double Diff = 0;
int length = ReadInt("Array length");
double[] array = GetRandomArray(length);


PrintArray(array);
System.Console.WriteLine(" / ");
FindDifference(array);
System.Console.WriteLine($"Разница между максимальным и минимальным значением: {Diff}");

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}, ");
    }
}

double[] GetRandomArray(int length)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = random.Next(1, 10) + random.NextDouble();
    }
    return array;
}

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

void FindDifference(double[] array)
{   double maxElement = array[0];
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
        if (array[i] < maxElement)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }
    }
    Diff = Math.Round((maxElement - minElement), 2);
}