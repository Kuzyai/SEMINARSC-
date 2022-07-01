// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/* double[,] Matrix(int m, int n)
{
	double[,] newMatrix = new double[m, n];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++) newMatrix[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);

	return newMatrix;
}
void ShowMatrix(double[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = Matrix(m, n);
ShowMatrix(matrix); */

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
/* int[,] Matrix(int m, int n)
{
	int[,] newMatrix = new int[m, n];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++) newMatrix[i, j] = new Random().Next(-9, 10);

	return newMatrix;
}
int[] Position()
{
	Console.Write("Введите позицию элемента через пробел, сначала строку, потом столбец: ");
	string position = Console.ReadLine();
	return position.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
}
void ShowMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
}
string PositionElementMatrix(int[,] matrix, int[] position)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (i == position[0] && j == position[1]) return $"Значение элемента на позиции 'индекс строки {i}' 'индекс столбца {j}' равно {matrix[i, j]} ";
		}
	}
	return $"Элемента на позиции 'индекс строки {position[0]}' 'индекс столбца {position[1]}' не существует.";
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
int[] position = Position();
ShowMatrix(matrix);
Console.WriteLine();
Console.WriteLine(PositionElementMatrix(matrix, position)); */

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/* int[,] Matrix(int m, int n)
{
	int[,] newMatrix = new int[m, n];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++) newMatrix[i, j] = new Random().Next(1, 10);

	return newMatrix;
}
void ShowMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]} ");
		Console.WriteLine();
	}
}
double[] AverageColumnMatrix(int[,] matrix)
{
	double[] averageColumn = new double[matrix.GetLength(1)];
	double sum = 0;
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			sum += matrix[i, j];
		}
		averageColumn[j] = sum / matrix.GetLength(0);
		sum = 0;
	}
	return averageColumn;
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
double[] averageColumn = AverageColumnMatrix(matrix);
ShowMatrix(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", averageColumn)}"); */