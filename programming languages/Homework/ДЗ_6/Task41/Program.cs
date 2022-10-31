// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//0 = = 0;



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");

}


int CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] > 0)
         {
             result ++;
          }
  }
  return result ;
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов > 0: " + (CountPositiveNumbers(array)));