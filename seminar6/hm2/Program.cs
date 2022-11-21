// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

const int K = 0;
const int B = 1;
const int X = 0;
const int Y = 1;

double Prompt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

void InputCoefficients(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Prompt($"Введите коэффициеты {i + 1}-го уравнения (y = k * x + b): ");
        array[i, K] = Prompt("Введите коэффициент k: "); ;
        array[i, B] = Prompt($"Введите коэффициент b: ");
    }
}

double[] PointCalculation(double[,] coeff)
{
    double[] point = new double[2];
    point[X] = (coeff[1, B] - coeff[0, B]) / (coeff[0, K] - coeff[1, K]);
    point[Y] = point[0] * coeff[0, 0] + coeff[0, 1];
    return point;
}

double[,] coefficient = new double[2, 2];

InputCoefficients(coefficient);
double[] crossPoint = PointCalculation(coefficient);
Console.WriteLine();
Console.Write($"Точка пересечения прямых: ({crossPoint[X]}, {crossPoint[Y]})");
Console.WriteLine();