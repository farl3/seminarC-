﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("первые max и min");
int a = 5;
int b = 7;

int max = 0;
int min = 10;

if (a > max) max = a;
if (b > max) max = b;
if (min > a) min = a;
if (min > b) min = b;

Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);

// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("вторые max и min");
int a1 = -9;
int b1 = -3;

int max1 = -10;
int min1 = 0;

if (a1 > max1) max1 = a1;
if (b1 > max1) max1 = b1;
if (min1 > a1) min1 = a1;
if (min1 > b1) min1 = b1;

Console.Write("max=");
Console.WriteLine(max1);
Console.Write("min=");
Console.WriteLine(min1);