// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n
Console.Clear();

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()); 

Console.Write($"Функция Аккермана = {FunctionAkkerman(m, n)} ");

int FunctionAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAkkerman (m - 1, 1);
  else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}
