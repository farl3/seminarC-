// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
    System.Console.Write(message);   //выводит сообщение в консоли
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
int N = Prompt("Введите число: ");
bool ValidateNumber(int N)
{
    if (N < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
if (ValidateNumber(N))
{
    while (N > 1000)
    {
        N = N / 10;
    }
    int A = N % 10;
    System.Console.WriteLine($"Третья цифра числа: {N} равна {A}");
}
