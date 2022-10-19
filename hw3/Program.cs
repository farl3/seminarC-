// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());
if (value % 2 == 0)
{Console.WriteLine($"{value}:четное число");}
else
{Console.WriteLine($"{value}:нечетное число");}