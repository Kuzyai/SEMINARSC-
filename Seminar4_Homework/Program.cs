// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/* int GetPow(int a, int b)
{
	int result = 1;
	for (int i = 1; i <= b; i++)
	{
		result *= a;
	}
	return result;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = GetPow(a, b);
Console.WriteLine(result); */

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/* void Array()
{
	int size = 8;
	int[] arr = new int[size];
	for (int i = 0; i < size; i++)
	{
		arr[i] = new Random().Next(0, 10);
	}
	Console.WriteLine(string.Join(", ", arr));
}

Array(); */