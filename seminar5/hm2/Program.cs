// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumEvenInd(int[] array)
{
    int sumEvenInd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumEvenInd += array[i];
    }
    return sumEvenInd;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
}

System.Console.WriteLine("Массив считается с нулевой позиции");  // 0 , 1 , 2 ...
int n = Prompt("Введите размер массива: ");
int min = Prompt("Введите минимальное значение массива: ");
int max = Prompt("Введите максимальное значение массива: ");
int[] randomArray = CreateArray(n, min, max);
int sum = SumEvenInd(randomArray);
PrintArray(randomArray);
System.Console.WriteLine("");
System.Console.Write($"Сумму элементов, стоящих на нечётных позициях массива: {sum}");
System.Console.WriteLine("");