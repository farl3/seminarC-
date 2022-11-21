// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] InputNumbers(int length)
{
    int[] massive = new int[length];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = Prompt($"Введите {i + 1}-e число: ");
    }
    return massive;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

int n = Prompt("Введите количество чисел (число M): ");
int[] massive = InputNumbers(n);
PrintArray(massive);
System.Console.WriteLine();
System.Console.Write($"Введено чисел больше 0: {CountPositive(massive)} ");
System.Console.WriteLine();