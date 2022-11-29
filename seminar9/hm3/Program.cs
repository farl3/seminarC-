﻿// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int GetAckermann(int m, int n) // вычисляет значение функции Аккермана
{
    if (m==0) return n+1;
    if (m>0 && n==0) return GetAckermann(m-1, 1);
    return GetAckermann(m-1, GetAckermann(m, n-1));
}

void Main() // тело программы
{
    int m = 3; // неотрицательное число, рекомендация, не выбирать значения больше 3 - значительное влияние на рост результата
    int n = 2; // неотрицательное число, рекомендация, не выбирать значения больше 5
    System.Console.WriteLine(GetAckermann(m, n));
}

Main();