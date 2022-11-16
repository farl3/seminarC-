// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int size, int min, int max)
{
    int[] randomArray = new int[size];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(min, max);
    }
    return randomArray;
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
}

int n = Prompt("Введите размер массива: ");
int min = Prompt("Введите минимальное значение массива: ");
int max = Prompt("Введите максимальное значение массива: ");
int[] randomArray = CreateArray(n, min, max);
int countEven = CountEven(randomArray);
PrintArray(randomArray);
System.Console.WriteLine("");
System.Console.Write($"Количество четных чисел в массиве: {countEven} ");
System.Console.WriteLine("");