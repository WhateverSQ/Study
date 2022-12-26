Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command (Task25/Tast27/Task29): ");
		switch (Console.ReadLine())
		{
			case "Task25": Task25(); break;
			case "Task27": Task27(); break;
            case "Task29": Task29(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Task25()
{
	int numberA = ReadInt("first number (A)");
	int numberB = ReadInt("second number (B)");

	Console.WriteLine($"The power {numberB} of number {numberA} is {Pow(numberA, numberB)}");
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Task27()
{
	int number = ReadInt("Enter number");
	Console.WriteLine(GetSum(number));
}

int GetSum(int number)
{
int result = 0;
result += number % 10;
number /= 10;
if (number > 0)
{
	result += GetSum(number);
}
return result;
}

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Task29()
{
	int[] array = GetArray(ReadInt("array length"));

	Console.WriteLine(ArrayToString(array));
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int Pow(int firstNumber, int secondNumber)
{
	int result = 1;

	for (int i = 0; i < secondNumber; i++)
	{
		result *= firstNumber;
	}

	return result;
}

int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"Element {i}");
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