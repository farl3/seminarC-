//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int replay(string text)
{Console.Write(text);
int number=Convert.ToInt32(Console.ReadLine());
return number;}
int number1=replay("Введите первое число:");
int number2=replay("Введите второе число:");
int number3=replay("Введите третье число:");
int max=number1;
if(max<number2)
{ max=number2;}
if(max<number3)
{max=number3;}
Console.WriteLine($"{max}:Максимальное число из введённых");