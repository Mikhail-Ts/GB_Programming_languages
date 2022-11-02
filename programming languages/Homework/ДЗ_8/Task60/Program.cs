// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//            Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//            Массив размером 2 x 2 x 2
Console.Clear();

void CreateArray(int[,,] array3)
{
  int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3.GetLength(0); x++)
  {
    for (int y = 0; y < array3.GetLength(1); y++)
    {
      for (int z = 0; z < array3.GetLength(2); z++)
      {
        array3[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void PrintArrayIndex(int[,,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3.GetLength(2); k++)
            {
                Console.Write($"{array3[i,j,k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] array3 = new int[2, 2, 2];
CreateArray(array3);
PrintArrayIndex(array3);
