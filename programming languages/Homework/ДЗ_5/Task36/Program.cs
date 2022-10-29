// Задача 34: Задайте одномерный массив, заполненный случайными числами.
//            Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] array = new int[size];
        Console.Write("Массив [");
    	for (int i = 0; i < array.Length; i++)
	    {
		    array[i] = new Random().Next(-99, 99);
            Console.Write($"{array[i]}  ");
	    }
    Console.Write("]");
    return array;
}

int SumNumbers(int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
			if (i % 2 != 0)
				sum = sum + array[i];
			else 
			    sum = sum;
	}

	return sum;
}


int[] array = CreateArray(size);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: " + (SumNumbers(array)));