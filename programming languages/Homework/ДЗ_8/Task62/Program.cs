// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Clear();

void  CreateArray(int[,] array, int len)
{
    int i = 0, j = 0;
    int value = 1;
    for (int a = 0; a < len * len; a++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < len - 1);
        for (k = 0; k < len - 1; k++) array[i++, j] = value++;
        for (k = 0; k < len - 1; k++) array[i, j--] = value++;
        for (k = 0; k < len - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        if( len < 2) 
            len = 0; 
        else len = len - 2;
        
    }
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

int[,] array = new int[4, 4];
CreateArray(array, array.GetLength(0));
PrintArray(array);
