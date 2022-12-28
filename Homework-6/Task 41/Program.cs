// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int length = ReadInt("Array length");
int[] array = GetArray(length);
int count = 0;

System.Console.Write("You entered numbers: ");
PrintArray(array);
System.Console.WriteLine("");
CountNumGreaterThan0(array);
System.Console.WriteLine($"Numbers greater than 0: {count}");


int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"elemtn {i}");
	}

	return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void CountNumGreaterThan0(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
}