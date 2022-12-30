// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using System.Text;

Task34();

void Task34()
{
int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 100, 1000);
System.Console.WriteLine(GetArrayAsString(array));
System.Console.WriteLine(FindEven(array));
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

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] FindEven(int [] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
    
}
System.Console.WriteLine($"Количество четных чисел: {count}");

return array;
}

string GetArrayAsString (int[] array)
{
    StringBuilder sb = new StringBuilder(array.Length); //Создает строку. Чтобы работал, нужно в начале файла написать using System.Text; в скобках минимальный размер строки.
    for (int i = 0; i < array.Length; i++)
    {
        sb.Append($"{array [i]} , "); //StringBuilder добавит в себя эту строку
    }
    return sb.ToString();
}