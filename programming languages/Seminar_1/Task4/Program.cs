//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());

if(a>b && a>c)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else if(b>a && b>c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(c);
}