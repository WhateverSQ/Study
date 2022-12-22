// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X для точки A: ");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки A: ");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки A: ");
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X для точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки B: ");
int yB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки B: ");
int zB = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
Console.Write("Расстояние между точками = ");
Console.Write(Math.Round(result, 3));