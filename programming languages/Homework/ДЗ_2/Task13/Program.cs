// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number<=999 && number>=100)
{
    Console.WriteLine("Третье число: " + number%10);
}
else if (number <= 99)
{
   Console.WriteLine("третьей цифры нет");
}
else
{
    while (number>999)
    {
        number = number / 10;
    }
    Console.WriteLine("Третье число: " + number%10);

}
