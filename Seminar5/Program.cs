/* int[] ReplaceElementArray(int size)
{
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(-99, 100);
	}
	Console.WriteLine(string.Join(", ", array));
	for (int i = 0; i < size; i++)
	{
		array[i] *= -1;
	}
	return array;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = ReplaceElementArray(size);
Console.WriteLine(string.Join(", ", array)); */

/* int[] GetRandomArray(int size)
{
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(-20, 21);
	}
	return array;
}
string PresentDigitArray(int[] array, int num)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == num) return $"Число {num} присутствует в массиве {string.Join(", ", array)}";
	}
	return $"Число {num} не присутствует в массиве {string.Join(", ", array)}";
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray(size);
string digitArray = PresentDigitArray(array, num);
Console.WriteLine(digitArray); */

/* int[] GetRandomArray(int size)
{
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(-1000, 1001);
	}
	return array;
}
int CountElementArray(int[] array, int min, int max)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] >= min && array[i] <= max) sum++;
	}
	return sum;
}
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arr = GetRandomArray(size);
int result = CountElementArray(arr, min, max);
Console.WriteLine($"Количество элементов массива {string.Join(", ", arr)}, значения которых лежат в отрезке [{min},{max}] равно {string.Join(", ", result)}."); */
