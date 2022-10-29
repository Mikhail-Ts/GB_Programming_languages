// Задача 38: Задайте массив вещественных чисел.
//            Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

double[] CreateArray(int size)
{
	double[] array = new double[size];
        Console.Write("Массив [");
        Random random = new Random();
    	for (int i = 0; i < array.Length; i++)
	{
		array[i] =  random.NextDouble() * 100;
        Console.Write($"{array[i]}  ");
	}
    Console.Write("]");
    return array;
}

double ra(double[] array)
{
    double max = double.MinValue;
    foreach (var i in array) 
    {
        if (i > max) 
        {
            max = i;
        }
    }
    
    double min = double.MaxValue;
    foreach (var i in array) 
    {
        if (i < min) 
        {
            min= i;
        }
     }
    return max - min;

}

double[] array = CreateArray(size);
Console.WriteLine();
Console.WriteLine($"Разница между max и min: " + ra(array) );