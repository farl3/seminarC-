﻿//Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int Prompt(string message)
{
    System.Console.Write(message);   //выводит сообщение в консоли
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}

int N = Prompt("Введите трёхзначное число: ");  // запрос в консоле

while (N < 100 || N > 999)  // условие трёхзначного числа
{
    N = Prompt("Вы ввели не трёхзначное число, введите трёхзначное число:");  //повторный ввод
}

int step1 = N % 10;  // находим третью цифру числа (N)
int step2 = N / 10;  //  находим первые две цифры числа (N)
int step3 = step2 % 10;  // находим врорую цифру числа (N) 
int step4 = N / 100;  // находим первую цифру числа (N)
int result = step4 * 10 + step1; // первую цифру числа (N) * 10 и прибавили третью цифру числа (N)

System.Console.WriteLine($"Вы ввели число {N}, вторая цифра {step3} была удалена, результат: {result} ");  // вывод результата
