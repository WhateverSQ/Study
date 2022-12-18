Console.Write("Enter number:");
int number = int.Parse(Console.ReadLine());
for (int count = 1; count <= number; count++)
if (count % 2 == 0)
Console.Write($"{count},");