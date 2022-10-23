/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

int replay(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int value = replay("Введите число:");
int number = 2;
while (value <= 1)
{
    value = replay("Введите число которое больше 1:");
}
while (value >= number)
{
    {
        Console.WriteLine($" {number}");
        number = number + 2;
    }
}
