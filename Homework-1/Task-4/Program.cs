﻿Console.WriteLine("Number A");
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Number B");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Number C");
int c = int.Parse(Console.ReadLine()); 
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.Write("max = ");
Console.Write(max);