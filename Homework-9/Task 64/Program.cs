// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
int n = ReadInt("Введите положительное число N: ");
int m = 1;

if (n < 1)
{
Console.WriteLine("Вы ввели не положительное число");
return;
}
Console.Write("Натуральные числа от N до 1: ");
Console.Write($"{ShowAllNaturalNumb(n, m)}");

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int ShowAllNaturalNumb(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{ShowAllNaturalNumb(n, m + 1)}, ");
    return m;
}