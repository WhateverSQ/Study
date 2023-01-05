// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");

System.Console.WriteLine($"Сумма натуральных элементов от {m} до {n}: {SumNaturalNumbers(m, n)}");

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int SumNaturalNumbers(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNaturalNumbers(m, n - 1);
}