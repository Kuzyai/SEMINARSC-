// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/* int[] RandomArray(int size)
{
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = new Random().Next(100, 1000);
	}
	return arr;
}
int SumHonestDigitArray(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0) sum++;
	}
	return sum;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size);
int count = SumHonestDigitArray(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count); */

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/* int[] RandomArray(int size)
{
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = new Random().Next(100, 1000);
	}
	return arr;
}
int SumNotEvenPositionElementsArray(int[] array)
{
	int sum = 0;
	for (int i = 1; i < array.Length; i += 2)
	{
		sum += array[i];
	}
	return sum;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size);
int sum = SumNotEvenPositionElementsArray(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(sum); */

// Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.
/* double[] RandomArray(int size)
{
	double[] arr = new double[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = new Random().NextDouble() * 100;
	}
	return arr;
}
double DifferenceMaxMinDigits(double[] array)
{
	int i = 0;
	double min = array[i];
	double max = array[i];
	for (; i < array.Length; i++)
	{
		if (array[i] < min) min = array[i];
		if (array[i] > max) max = array[i];
	}
	return max - min;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = RandomArray(size);
double result = DifferenceMaxMinDigits(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(result); */