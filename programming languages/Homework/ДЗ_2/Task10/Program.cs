// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int secondNumber = 0;
if(number<=999 && number>=100)
{
    secondNumber = (number - ((number/100) * 100)) /10;
    Console.WriteLine("Второе число: " + secondNumber);
}
else
{
    Console.WriteLine("Ведено не трехзначное число");
};


