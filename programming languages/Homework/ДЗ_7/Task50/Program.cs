// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();

Console.Write("Введите строку поиска: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите столбец поиска: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 99);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
       Console.WriteLine();
    } 
    
}

void FindNumber(int[,] array)
{
   if(a>array.GetLength(0) || b>array.GetLength(1))
   Console.Write("Задан поиск за пределами массива");
   else 
   Console.Write(array[a,b]);
}

int[,] array = GetArray(10, 10); 
PrintArray(array);
Console.WriteLine("");
Console.Write($"Значение в строке {a} и столбце {b}: "); 
FindNumber(array);
 