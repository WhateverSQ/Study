// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Enter number from -999: ");
int number = int.Parse(Console.ReadLine());
int ThirdNum = 0;
if (number >= 100 | number <=-100 && number >= -999)
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine($"Third digit is {ThirdNum = Math.Abs(number) % 10}");
}
else 
{
    if (number <= 99 && number >= -99)
    {
    Console.WriteLine("There is no trird digit");
    }
}

