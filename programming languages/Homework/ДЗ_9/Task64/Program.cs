// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//            Выполнить с помощью рекурсии.
Console.Clear();

Console.WriteLine("Введите число больше 1:");
int N = int.Parse (Console.ReadLine());
NumberCounter(N);

void NumberCounter (int N)
{
    if (N < 0) 
    {
        Console.Write($"{N} не натуральное число");
        return;
    }
    if (N  == 0) return;
    Console.Write($"{N} ");
    NumberCounter (N - 1);
}

