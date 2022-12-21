// =============================================================

// Удалить вторую цифру трёхзначного числа
// 123 > 13
// 1.
// ГЛАВНАЯ ЗАДАЧА
// 100 <= n <= 999
// число, которое вводит юзер
// как выводить резуульта 
// 123 
// 13
// 123 -> 13
// 012
// -214: Abs(-214) = 214 -> 24
// -214: Abs(-214) = 214 -> -24
// 
// 2.
// 2.1. Метод, который -> Ввод числа
// 2.2. Метод, который -> Проверка числа на валидность
// 2.3. Метод, который -> Отковырять вторую цифру +++
// 2.4. Метод, который -> Распечать результат
// 2.5. Метод, который -> Декоратор для вывода
//
// 3. 
// ___
// abc = a*100 + b*10 + c 
// 456 = 4*100 + 5*10 + 6
// ___
//  ac = a*10 + c 
//  

// ДЕЛЕНИЕ  Целочисленное        14 div 5 => 2       int / int => int
//          Обычное              14 / 5 => 2.8       double / int = double
//                                                   int / double = double
//                                                   double / double = double
//          Остатком             14 mod 5 => 4       int % int => int
// ___
// abc = value
// a = value div 100
// b = (value div 10) mod 10
// c = value mod 10


// 2.1. Метод, который -> Ввод числа
int GetNumberFromUser()
{
  Console.Write("Введите число от 100 до 999: ");
  int temp = int.Parse(Console.ReadLine());
  return temp;
}

// 2.2. Метод, который -> Проверка числа на валидность
bool IsValid(int number)
{
  // and -> &&
  return number >= 100 && number <= 999;
  // if (number >= 100)
  // {
  //   if (number <= 999)
  //   {
  //     return true;
  //   }
  // }
  // return false;
}

// 2.3. Метод, который -> Отковырять вторую цифру +++
int GetNumber(int value)
{
  int a = value / 100;
  int b = (value / 10) % 10;
  int c = value % 10;

  return a * 10 + c;
}

// 2.4. Метод, который -> Распечать результат
string GetText(int input, int output)
{
  return input + " -> " + output;
}

// 2.5. Метод, который -> Декоратор для вывода

string Decorator(string text)
{
  Console.Clear();
  Console.ForegroundColor = ConsoleColor.Red;
  return text;
}


void Decorator2(string text)
{
  Console.Clear();
  System.Console.WriteLine("❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️");
  ConsoleColor old = Console.ForegroundColor;
  Console.ForegroundColor = ConsoleColor.Red;
  System.Console.WriteLine(text);
  Console.ForegroundColor = old;
  System.Console.WriteLine("❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️");
}

void Task10()
{
  int value = GetNumberFromUser();

  if (IsValid(value))
  {
    int result = GetNumber(value);
    //System.Console.WriteLine(GetText(value, result));
    Decorator2(GetText(value, result));
  }
  else
  {
    System.Console.WriteLine("число кривое");
  }
}

// =============================================================
//Task10();




// 36. Задать массив, заполнить случайными положительными
//     трёхзначными числами. Показать количество нечетных\четных чисел


// 0. Получение числа, которое можно использовать для создания массива

// 1. Метод создания массива с указанным размером
// int[] CreateArray(int count)
int[] CreateArray(int count)
{
  return new int[count];
}
// 2. Метод заполения
//  void Fill(int[] array, int min, int max)
void Fill(int[] array, int min, int max)
{
  int count = 0;
  int length = array.Length;
  while (count < length)
  {
    int element = new Random().Next(min, max + 1);
    array[count] = element;
    count++;
  }

}
// 3. Вывод результата
//   string Print(int[,] pair) 
void Print1(int[] pair)
{
  Console.WriteLine("Количество четных чисел в массиве " + pair[0]);
  Console.WriteLine("Количество нечетных чисел в массиве " + pair[1]);
}

// 4. Метод подсчёта четных\нечетных
int[] JoinJob(int[] data)
{
  int[] result = { 0, 0 };
  int size = data.Length;
  int index = 0;
  while (index < size)
  {
    if (data[index] % 2 == 0) result[0]++;
    if (data[index] % 2 != 0) result[1]++;
    index++;
  }
  return result;
}

int[] inputData = CreateArray(100);
Fill(inputData, 0, 10);
int[] result = JoinJob(inputData);
Print1(result);

System.Console.WriteLine();










string OutputDecorator(int[] data, string text)
{
  return text + "\nНулевых элементов: " + data[2];