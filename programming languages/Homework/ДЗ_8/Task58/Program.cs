// Задача 58: Задайте две матрицы. 
//            Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 99);;
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] array1, int[,] array2, int[,] resultArray) //Произведение матриц
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int x = 0; x < array1.GetLength(1); x++)
      {
        sum += array1[i,x] * array2[x,j];
      }
      resultArray[i,j] = sum;
    }
  }
}


int[,] array1 = new int[2, 2];
GetArray(array1); 
Console.WriteLine("Изначальный массив 1:");
PrintArray(array1);
int[,] array2 = new int[2, 2];
GetArray(array2); 
Console.WriteLine("Изначальный массив 2:");
PrintArray(array2);
int[,] resultArray = new int[2, 2];
MultiplyMatrix(array1, array2, resultArray); 
Console.WriteLine("Произведение матриц:");
PrintArray(resultArray);
