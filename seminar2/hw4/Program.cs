//Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);   
    return int.Parse(Console.ReadLine());   
}

int N = Prompt("Введите число от 1 до 7, соответствующее дню недели: ");

bool ValidateNumber(int N)
{
    if (N < 1 || N > 7)
    {
        System.Console.WriteLine("Введённое число не соответстует дню недели");
        return false;
    }
    return true;
}
if (ValidateNumber(N))
{
    if (N >= 1 && N < 6)
    {
        System.Console.WriteLine($"{N} не является выходным днём");
    }
    else
    {
        System.Console.WriteLine($"{N} является выходным днём");
    }
   
}