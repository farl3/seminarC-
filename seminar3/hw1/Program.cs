// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    System.Console.Write(message);   //выводит сообщение в консоли
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}


int N, A, sum = 0, temp;  // пременные
N = Prompt("Введите число: ");  // запрос с консоли
temp = N;
while (Convert.ToBoolean(N))  // перобразование к равнозначному значению
{
    A = N % 10;
    N = N / 10;
    sum = sum * 10 + A;
}

if (temp == sum)
{
    System.Console.WriteLine($"число {temp} является палидромом");
}
else
{
    System.Console.WriteLine($"число {temp} не является палидромом");
}