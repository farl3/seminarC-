// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

System.Console.WriteLine("Данная программа принимает на размер массива n, минимальное min и максимальное max значение для генерации случайных чисел, создает массив заданной размерности случайными числами в заданном диапазоне.");
int n = Prompt("Введите размер массива - n: ");
int min = Prompt("Введите минимальное значение случайного числа - min: ");
int max = Prompt("Введите максимальное значение случайного числа - max: ");

System.Console.Write($"Случайный массив длиной {n} со значениями от {min} до {max}: ");
int[] maxArray = CreateArray(n, min, max);
PrintArray(maxArray);

System.Console.WriteLine("");