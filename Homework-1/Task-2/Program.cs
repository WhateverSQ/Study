Console.WriteLine("Number A");
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Number B");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = a;
if(b > max) 
{
max = b;
}
else
{
min = b;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);