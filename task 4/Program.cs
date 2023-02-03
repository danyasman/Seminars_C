// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int num_3 = int.Parse(Console.ReadLine()!);

if (num_1 > num_2)
{
    if (num_1 > num_3)
    {
        Console.WriteLine($"Максимальное из данных 3-х чисел: {num_1} ");
    }
    else
    {
        Console.WriteLine($"Максимальное из данных 3-х чисел: {num_3} ");
    }
}
else if (num_2 > num_3)
{
    Console.WriteLine($"Максимальное из данных 3-х чисел: {num_2} ");
}
else 
{
    Console.WriteLine($"Максимальное из данных 3-х чисел: {num_3} ");
}