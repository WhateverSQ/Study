Console.Write("Enter number from 100 to 999: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <=999)
{
    int Second = (number / 10) % 10;
    Console.WriteLine($"Second number is {Second}");
}
else 
{
    Console.WriteLine("Invalid number");
}