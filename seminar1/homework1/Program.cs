// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

int replay(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number1 = replay("Введите первое число:");
int number2 = replay("Введите второе число:");
if (number1 > number2)
{
    Console.WriteLine($"Максимальное число={number1}, минимальное число={number2}");
}
if (number1 < number2)
{
    Console.WriteLine($"Максимальное число={number2}, минимальное число={number1}");
}
if (number1 == number2)
{
    Console.WriteLine("Вы ввели равные числа");
}