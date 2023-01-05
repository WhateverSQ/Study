// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int m = ReadInt("Input M");
int n = ReadInt("Input N");

Console.WriteLine($"Функция Аккермана от {m} и {n}: {Ackerman(m , n)}");

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}


int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Ackerman(m - 1, 1);
    else 
        return Ackerman (m - 1, Ackerman(m, n - 1));
}

