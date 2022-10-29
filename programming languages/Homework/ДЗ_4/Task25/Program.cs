// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

Degree(a, b);

#region  Degree
void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + "^" + b + " = " + result);
}
#endregion
