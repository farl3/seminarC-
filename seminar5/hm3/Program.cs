// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int size, int minVal, int maxVal)
{
    double[] randomArray = new double[size];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = (new Random().Next(minVal, maxVal) + new Random().NextDouble());
    }
    return randomArray;
}

void PrintArray(double[] array)
{
    Console.Write($"{array[0]:f2}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]:f2}");
    }
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double MaxMin(double[] array)
{
    double max = Max(array);
    double min = Min(array);
    double maxmin = max - min;
    return maxmin;
}

void Print()
{
    int n = Prompt("Введите размер массива: ");
    int min = Prompt("Введите минимальное значение массива: ");
    int max = Prompt("Введите максимальное значение массива: ");
    double[] randomArray = CreateArray(n, min, max);
    double a = Max(randomArray);
    double b = Min(randomArray);
    double maxmin = MaxMin(randomArray);
    PrintArray(randomArray);
    System.Console.WriteLine("");
    System.Console.Write($"Разница между максимальным {a:f2} и минимальным {b:f2} элементами массива = {maxmin:f2}");
    System.Console.WriteLine("");
}
Print();


