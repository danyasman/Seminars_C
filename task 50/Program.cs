// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int M, int N, int minValue, int maxValue)
{
    int[,] result = new int[M, N];

    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
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
void ElementSelection(int[,] Array, int numberLine, int numberPillar)
{
    if (Array.GetLength(0) > numberLine && Array.GetLength(1) > numberPillar)
    {
        Console.WriteLine(Array[numberLine, numberPillar]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}
Console.Write("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int pillar = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(line, pillar, -10, 10);
Console.Write("Введите номер строки: ");
int numberLine = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите номер столбца: ");
int numberPillar = int.Parse(Console.ReadLine()!) - 1;
PrintArray(array);
ElementSelection(array, numberLine, numberPillar);