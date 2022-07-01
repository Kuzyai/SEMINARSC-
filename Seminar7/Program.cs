/* int[,] Matrix(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++) array[i, j] = i + j;

	return array;
}
void MatrixOutput(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
		Console.WriteLine();
	}
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = Matrix(m, n);
MatrixOutput(array); */

/* int[,] Matrix(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++) array[i, j] = i + j;

	return array;
}
int[,] PowMatrix(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i += 2)
		for (int j = 0; j < array.GetLength(1); j += 2) array[i, j] *= array[i, j];

	return array;
}
void MatrixOutput(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
		Console.WriteLine();
	}
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = Matrix(m, n);
MatrixOutput(array);
int[,] powArray = PowMatrix(array);
Console.WriteLine();
MatrixOutput(powArray); */

int[,] Matrix(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++) array[i, j] = i + j;

	return array;
}
int SumElementsDiagonalMatrix(int[,] array)
{
	int sum = 0;
	for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++) sum += array[i, i];

	return sum;
}
void MatrixOutput(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
		Console.WriteLine();
	}
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = Matrix(m, n);
int sumArray = SumElementsDiagonalMatrix(array);
MatrixOutput(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов находящихся на главной диагонали матрицы = {sumArray}");