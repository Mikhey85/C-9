// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = Prompt ("Введите число: ");
AllNumbersupN(n);

int Prompt (string mesage)
{
    Console.Write(mesage);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void AllNumbersupN (int num)
{
    if ( num >= 1)
    {
        Console.Write($"{num} ");
        AllNumbersupN(num-1);
    }
}