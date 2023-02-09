// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите число: ");
int num = int.Parse(Console.ReadLine()!);

if(num < 100 || num == 0)
    {
        System.Console.WriteLine("третьей цифры нет или значене равно 0");
    }
while(num > 1000)
{
    num /= 10;
}
if(num > 100)
    {
     num = num % 10;
     System.Console.WriteLine($"третья цифра {num}");
    }