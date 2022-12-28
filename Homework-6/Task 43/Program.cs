// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());

double y = 0;
double x = 0;

FindIntersection(b1, k1, b2, k2);

void FindIntersection(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        System.Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны");
    }
    else
    {
    x = (b2 - b1) / (k1 - k2);
    y = (k1*(b2-b1))/(k1-k2)+b1;
    System.Console.WriteLine($"Координаты точки пересечения двух прямых: {x}, {y}");
    }
}