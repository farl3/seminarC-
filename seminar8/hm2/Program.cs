// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandomArrayOfInt(int rows, int cols, int min, int max)
{
    int[,] temp = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            temp[i, j] = new Random().Next(min, max + 1);
        }
    }
    return temp;
}

void PrintArrayOfInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i, 0]}\t");
        for (int j = 1; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SumOfRow(int[,] array, int row)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp += array[row, j];
    }
    return temp;
}

(int numRow, int minSum) FindRowWithMinSum(int[,] array)
{
    int minRow = 0;
    int minSum = SumOfRow(array, minRow);
    int temp = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        temp = SumOfRow(array, i);
        if (temp < minSum)
        {
            minSum = temp;
            minRow = i;
        }
    }
    return (minRow, minSum);
}

void PrintRowWithMinSum(int[,] array)
{
    int numRow = 0;
    int minSum = 0;
    (numRow, minSum) = FindRowWithMinSum(array);
    System.Console.WriteLine($"В данном массиве у строки под номером {numRow + 1} сумма элементов наименьшая и равна {minSum}. Нумерация строк начинается с 1.");
}

void Execute() // Основное тело программы
{
    System.Console.Clear();

    // === Блок с константами для удобного управления параметрами массива ===
    const int rowsInArray = 4;
    const int colsInArray = 3;
    const int minOfRandom = 0;
    const int maxOfRandom = 5;
    // === Конец блока констант ===

    int[,] arrayOfInt = CreateRandomArrayOfInt(rowsInArray, colsInArray, minOfRandom, maxOfRandom);
    PrintArrayOfInt(arrayOfInt);
    System.Console.WriteLine();
    PrintRowWithMinSum(arrayOfInt);
}

Execute();