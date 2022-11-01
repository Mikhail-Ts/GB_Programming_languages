// Задача 56: Задайте прямоугольный двумерный массив. 
//            Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void RowMinSumElements(int[,] array) //Вывод номера строки с наименьшей суммой элементов
{
    int tempSumRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tempSumRow += array[0, i];
    }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
                if (sumRow < tempSumRow)
                {
                sumRow = tempSumRow;
                minSumRow = i;
                }
        sumRow = 0;
        }
    Console.Write($"Номер строки с наименьшей суммой элементов: {minSumRow+1}");
}


int[,] array = GetArray(4, 4); 
Console.WriteLine("Изначальный массив:");
PrintArray(array);
Console.WriteLine();
RowMinSumElements(array);