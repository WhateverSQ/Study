// Получает две точки и выдает номер четверти плоскости, в которых они находятся. X != 0; y != 0;
//Console.Write("Введите x:");
//int x = int.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//int y = int.Parse(Console.ReadLine());
//int qwarter = 0;
//if (x > 0)
//{
//    if (y > 0)
//    {
//        qwarter = 1;
//    }
//    else
//    {
//       qwarter = 4;
//    }
//}
//else
//{
//    if (y > 0)
//    {
//        qwarter = 2;
//    }
//    else
//    {
//       qwarter = 3;
//    }
//}
//Console.WriteLine($"X {x},Y {y} is {qwarter} qwarter");

//Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

//Console.Write("Введите номер четверти: ");
//int qwarter = int.Parse(Console.ReadLine());
//int Xmax = 0;
//int Ymax = 0;
//int Xmin = 0; 
//int Ymin = 0;
//if (qwarter == 1)
//{
//    Xmin = 1;
//    Ymin = 1;
//    Xmax = int.MaxValue;
//    Ymax = int.MaxValue;
//}
//else if (qwarter == 2)
//{
//    Xmin = int.MinValue;
//    Ymin = -1;
//    Xmax = -1;
//    Ymax = int.MaxValue;
//}
//else if (qwarter == 3)
//{
//    Xmin = int.MinValue;
//    Ymin = int.MinValue;
//    Xmax = -1;
//    Ymax = -1;
//}
//else if (qwarter == 4)
//{
//    Ymin = int.MinValue;
//    Xmin = 1;
//    Xmax = int.MaxValue;
//    Ymax = -1;
//}
//Console.WriteLine($"Диапазон координат X = от {Xmin} до {Xmax}");
//Console.WriteLine($"Диапазон координат Y = от {Ymin} до {Ymax}");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2д пространстве.

//√((xb - xa)2 + (yb - ya)2)

//Console.WriteLine("Введите координату X для точки A: ");
//int xA = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату Y для точки A: ");
//int yA = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату X для точки B: ");
//int xB = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату Y для точки B: ");
//int yB = int.Parse(Console.ReadLine());
//double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
//Console.Write("Расстояние между точками = ");
//Console.Write(Math.Round(result, 3));

//Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
for (double i = 1; i <= N; i++)
{
    Console.WriteLine($"{Math.Pow(i, 2)}");

}
