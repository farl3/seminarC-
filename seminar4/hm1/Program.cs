// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool IsEven(int n)
{
    if (n % 2 == 0) return true;
    return false;
}

bool IsNegative(int n)
{
    if (n < 0) return true;
    return false;
}

int CustomPower(int Base, int Power)
{
    if (Power == 0) return 1;
    if (IsNegative(Power)) Power *= -1;
    if (IsEven(Power))
    {
        int Result = CustomPower(Base, Power / 2);
        return Result * Result;
    }
    else return Base * CustomPower(Base, Power - 1);
}

System.Console.WriteLine("Данная программа принимает на ввод два числа (А и В) и возводит число А в натуральную степень В");
int a = Prompt("Введите целое число А: ");
int b = Prompt("Введите целое число B: ");
if (IsNegative(b)) System.Console.Write("Степень равна: 1/");
else System.Console.Write("Степень равна: ");
System.Console.Write(CustomPower(a, b));