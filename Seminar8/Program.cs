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
int[,] ReplaceRowsMatrix(int[,] matrix)
{
	int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1)];
	for (int i = 0; i < matrix.GetLength(0); i++)
		for (int j = 0; j < matrix.GetLength(1); j++)
			if (i == 0)
			{
				temp[i, j] = matrix[i, j];
				matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
				matrix[matrix.GetLength(0) - 1, j] = temp[i, j];
			}
	return matrix;
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
ShowMatrix(matrix);
int[,] replaceRows = ReplaceRowsMatrix(matrix);
Console.WriteLine();
ShowMatrix(replaceRows); */

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
int[,] TransponationMatrix(int[,] matrix)
{
	int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1)];
	if (matrix.GetLength(0) != matrix.GetLength(1)) temp = new int[matrix.GetLength(1), matrix.GetLength(0)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			temp[j, i] = matrix[i, j];
		}
	}
	return temp;
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
ShowMatrix(matrix);
matrix = TransponationMatrix(matrix);
Console.WriteLine();
ShowMatrix(matrix); */

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
int[,] DelleteColumnRowsMinElementMatrix(int[,] matrix)
{
	int m = 0, n = 0;
	matrix[m, n] = matrix[0, 0];
	for (int i = 0; i < matrix.GetLength(0); i++)
		for (int j = 0; j < matrix.GetLength(1); j++)
			if (matrix[m, n] > matrix[i, j])
			{
				m = i;
				n = j;
			}
	for (int i = 0; i < matrix.GetLength(0); i++) matrix[i, n] = 0;
	for (int j = 0; j < matrix.GetLength(1); j++) matrix[m, j] = 0;

	return matrix;
}
int[,] MinDelleteMatrix(int[,] matrix)
{
	int[,] minDellete = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
	for (int i = 0, m = 0; i < matrix.GetLength(0); i++)
	{
		if (matrix[i, 0] == 0 && matrix[i, matrix.GetLength(1) - 1] == 0) continue;
		for (int j = 0, n = 0; j < matrix.GetLength(1); j++)
			if (matrix[i, j] != 0) minDellete[m, n++] = matrix[i, j];
		m++;
	}
	return minDellete;
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Matrix(m, n);
ShowMatrix(matrix);
matrix = DelleteColumnRowsMinElementMatrix(matrix);
Console.WriteLine();
ShowMatrix(matrix);
matrix = MinDelleteMatrix(matrix);
Console.WriteLine();
ShowMatrix(matrix); */