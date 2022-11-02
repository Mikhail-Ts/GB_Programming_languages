// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()); 

SumOfNumbers(M, N, 0);

void SumOfNumbers (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма: {sum}"); 
        return;
    }
    sum = sum + (M++);
    SumOfNumbers(M, N, sum);
}

