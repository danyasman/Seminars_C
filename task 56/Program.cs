// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void FillArrayRandomNumbers(int[,] inArray)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        min += inArray[0, i];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) sum += inArray[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"Строка с наименьшей суммой элементов под номером: {minSum + 1}, с суммой элементов равной: {min}");
}

Console.Write("Введите кол-во строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(str, col, -10, 10);
PrintArray(array);
FillArrayRandomNumbers(array);