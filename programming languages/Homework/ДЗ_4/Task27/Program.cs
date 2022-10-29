// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

Console.Write("Введите число: ");
string N = Console.ReadLine();
main (N);

#region  main
void main (string N)
{
int[] array = new int[N.Length];
int result = 0;
for( int i=0; i< array.Length; i++)
{
     array[i] = int.Parse(N[i].ToString());
     result = result + array[i];
}
Console.WriteLine(result);
}
#endregion