// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] array = new int[size];
        Console.Write("Массив [");
    	for (int i = 0; i < array.Length; i++)
	    {
		    array[i] = new Random().Next(100, 999);
            Console.Write($"{array[i]}  ");
	    }
    Console.Write("]");
    return array;
}

int NumberOfEvenNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2==0)
        count ++;
        else; count = count;
    }
        
    Console.Write($"{count} ");
    return count;
}


int[] array = CreateArray(size);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: " + (NumberOfEvenNumbers(array)));