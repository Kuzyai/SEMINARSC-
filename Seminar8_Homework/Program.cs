// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
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
int[,] SortMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
		for (int j = 0; j < matrix.GetLength(1); j++)
			for (int k = 0; k < matrix.GetLength(1) - 1; k++)
				if (matrix[i, k] > matrix[i, k + 1])
				{
					int temp = matrix[i, k];
					matrix[i, k] = matrix[i, k + 1];
					matrix[i, k + 1] = temp;
				}
	return matrix;
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
ShowMatrix(matrix);
matrix = SortMatrix(matrix);
Console.WriteLine();
ShowMatrix(matrix); */

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* int[,] Matrix(int m)
{
	int[,] newMatrix = new int[m, m];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < m; j++) newMatrix[i, j] = new Random().Next(1, 10);

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
int[] ArrayRowsMatrix(int[,] matrix)
{
	int[] array = new int[matrix.GetLength(0)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
		array[i] = sum;
	}
	return array;
}
int NumMinSumRowsMatrix(int[] array)
{
	int result = array[0];
	int str = 1;
	for (int i = 0; i < array.Length; i++)
		if (array[i] < result)
		{
			result = array[i];
			str = i + 1;
		}
	return str;
}
Console.Write("Введите количество строк и столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m);
ShowMatrix(matrix);
int[] array = ArrayRowsMatrix(matrix);
int num = NumMinSumRowsMatrix(array);
Console.WriteLine($"{num} строка"); */

// Заполните спирально массив 4 на 4.
/* int[,] SpiralMatrix(int m)
{
	int[,] newMatrix = new int[m, m];
	int num = 1, i = 0, k = 1;
	for (int j = 0; j < newMatrix.GetLength(1); j++) newMatrix[i, j] = num++;
	num--;
	for (int j = newMatrix.GetLength(1) - k; i < newMatrix.GetLength(0); i++) newMatrix[i, j] = num++;
	num--;
	i--;
	for (int j = newMatrix.GetLength(1) - k; j >= 0; j--) newMatrix[i, j] = num++;
	num--;
	for (int j = 0; i >= k; i--) newMatrix[i, j] = num++;
	i++;
	for (int j = k; j < newMatrix.GetLength(1) - k; j++) newMatrix[i, j] = num++;
	num--;
	for (int j = newMatrix.GetLength(1) - ++k; i < newMatrix.GetLength(0) - 1; i++) newMatrix[i, j] = num++;
	num--;
	i--;
	for (int j = newMatrix.GetLength(1) - k; j >= k - 1; j--) newMatrix[i, j] = num++;

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


int m = 4;
int[,] matrix = SpiralMatrix(m);
ShowMatrix(matrix); */