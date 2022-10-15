//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if (a < b)
{
    Console.Write("min = ");
    Console.WriteLine(a);
    Console.Write("max = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("min = ");
    Console.WriteLine(b);
    Console.Write("max = ");
    Console.WriteLine(a);
}