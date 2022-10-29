// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите день недели (от 1 до 7): ");
int day = int.Parse(Console.ReadLine());

if(day<=5)
{
    Console.WriteLine("нет");
}
else if (day<=7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Некорректное число");
}