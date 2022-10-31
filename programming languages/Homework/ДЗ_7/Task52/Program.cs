// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

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


void ArithmeticMeanColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {  
        double ArithmeticMean = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            ArithmeticMean = ArithmeticMean + array[i, j]; 
        }
        Console.WriteLine("Среднее арифметическое столбца {0} : {1}  ", j, (Math.Round(ArithmeticMean / array.GetLength(0), 1))); 
    } 
}

int[,] array = GetArray(3, 4); 
PrintArray(array);
Console.WriteLine();
ArithmeticMeanColumn(array);