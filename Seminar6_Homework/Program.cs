// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* int PositivDigits(string[] subs)
{
	int count = 0;
	int j;
	for (int i = 0; i < subs.Length; i++)
	{
		j = Convert.ToInt32(subs[i]);
		if (j > 0) count++;
	}
	return count;
}
string[] Subs()
{
	Console.Write("Введите числа по порядку через пробел :");
	string M = Console.ReadLine();
	return M.Split(" ");
}
string[] subs = Subs();
Console.WriteLine(string.Join(", ", subs));
int result = PositivDigits(subs);
Console.WriteLine(result); */

// Решене 1-й задачи другим способом
/* int PositivDigits(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > 0) count++;
	}
	return count;
}
int[] MyArray()
{
	int elem;
	int size = 1;
	int[] M = new int[size];
	Console.WriteLine("Введите числa по порядку.");
	for (int i = 0; i < size; i++, size++)
	{
		try
		{
			Console.Write("Введите число: ");
			elem = Convert.ToInt32(Console.ReadLine());
			Array.Resize(ref M, M.Length + 1);
			M[i] = elem;
		}
		catch (FormatException)
		{
			Array.Resize(ref M, M.Length - 1);
			return M;
		}
	}
	return M;
}
int[] myArray = MyArray();
Console.WriteLine(string.Join(", ", myArray));
int result = PositivDigits(myArray);
Console.WriteLine(result); */

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/* int[] CopyArray(int[] array)
{
	int[] copy = new int[array.Length];
	int i = 0;
	foreach (int elem in array)
	{
		copy[i] = elem;
		i++;
	}
	return copy;
}
int[] array = { 54, 21, -5, 90, -56 };
int[] copyArray = CopyArray(array);
Console.WriteLine(string.Join(", ", copyArray)); */