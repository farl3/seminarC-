//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool IsNegative(int n)
{
    if (n < 0) return true;
    return false;
}

int Sum(int n)
{
    Console.Write($"Сумма цыфр числа {n} равна: ");
    if (IsNegative(n)) n *= -1;
    int result = 0;
    while (n > 0)
    {
        result += n % 10;
        n /= 10;
    }
    return result;
}

Console.WriteLine("Данная программа принимает на ввод число и выдает сумму чифр в числе.");
int n = Prompt("Введите положительное целое число: ");
int result = Sum(n);
Console.WriteLine(result);