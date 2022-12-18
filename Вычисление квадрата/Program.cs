Console.WriteLine("Number");
int number = int.Parse(Console.ReadLine()); 
//метод, который позволяет полученный параметр преобразовать в число
double result = Math.Pow(number,2);
//Math - класс. Pow - Метод этого класса. Принимает два аргумента. number и степень.
System.Console.WriteLine($"Квадрат от числа {number} равен {result}");
//$ перед ковычками позволяет использовать фигурные скобки и передавать через них данные из другого кода.