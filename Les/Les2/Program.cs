//Функция для нахождения максимального числа
//int Max(int arg1, int arg2, int arg3)
//{
//    int result = arg1;
//    if (arg2 > result) result = arg2;
//    if (arg3 > result) result = arg3;
//    return result;
//}
//int a1 = 15;
//int b1 = 12;
//int c1 = 16;
//int a2 = 42;
//int b2 = 53;
//int c2 = 112;
//int a3 = 23;
//int b3 = 21;
//int c3 = 41;
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
//int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));
//Console.WriteLine(max);

//Массив
//int Max(int arg1, int arg2, int arg3)
//{
//    int result = arg1;
//    if (arg2 > result) result = arg2;
//    if (arg3 > result) result = arg3;
//    return result;
//}
//int[] array = {11, 12, 42, 421, 34, 32, 12, 52, 21};
//int max = Max(Max(array[0], array[1], array[2]),Max(array[3], array[4], array[5]),Max(array[6], array[7], array[8]));
//Console.WriteLine(max);

//
//int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
//int n = array.Length;
//int find = 4;
//int index = 0;
//while(index < n)
//{if(array[index] == find)
//{
//    Console.WriteLine(index);
//    break;
//}
//    index++;
//}

//Методы заполнения массива и печати на экран
void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);