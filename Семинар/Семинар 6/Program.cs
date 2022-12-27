// 39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)[1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
//int length = ReadInt("Array length");
//int[] array = GetRandomArray(length, 1, 5);

//PrintArray(array);
//Reverse(array);
//System.Console.WriteLine(" / ");
//PrintArray(array);

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины

//int a = ReadInt("Введите длину стороны А: ");
//int b = ReadInt("Введите длину стороны В: ");
//int c = ReadInt("Введите длину стороны С: ");

//VerifyTriangle(a, b, c);

void VerifyTriangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b)
    {
        System.Console.WriteLine("Треугольник имеет право на жизнь");
    }
    else
    {
        System.Console.WriteLine("Треугольник не существует");
    }
}

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.45 -> 101101 3 -> 11 2 -> 10

//int number = ReadInt("number");
//ChangeNum(number);

void ChangeNum(int number)
{
    string result = string.Empty;
    while (number != 0)
    {
        result += number % 2;
        number /= 2;
    }
    string Reverse(string result)
    {
    char [] array = result.Reverse().ToArray();
    string new_result = string.Empty;
    foreach(char c in array)
    {
        new_result+= c;
    }
    return new_result;
    }
    System.Console.WriteLine(Reverse(result));
}

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8

//int N = ReadInt("number");

//Console.WriteLine(ArrayToString(GetArray(N)));

int[] GetArray(int length)
{
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}

//45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int length = ReadInt("Array length");
int[] array = GetRandomArray(length, 1, 5);
int[] newArray = ArrayClone(array);

PrintArray(array);
System.Console.WriteLine(" / ");
PrintArray(newArray);

int[] ArrayClone(int[] array)
{
    int[] newArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}