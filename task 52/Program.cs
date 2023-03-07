// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] GetArray(int D, int G, int minValue, int maxValue)
{
    int[,] result = new int[D, G];

    for (int i = 0; i < D; i++)
    {
        for (int j = 0; j < G; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void ElementSum(int[,] Array)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum += Array[i, j];
        }
        double ArithmeticSum = Math.Round(sum / Array.GetLength(0), 2);
        Console.Write($"{ArithmeticSum}, ");
    }
}
Console.Write("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int pillar = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(line, pillar, -10, 10);
PrintArray(array);
ElementSum(array);