// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* string Palindrom(string num)
{
	char[] arr = num.ToCharArray();
	int countI = 0;
	int countJ = arr.Length - 1;
	while (countI <= arr.Length / 2)
	{
		if (arr[countI] == arr[countJ]) return "Да";
		else return "Нет";
		countI++;
		countJ--;
	}
	return "Конец";
}

Console.Write("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine(Palindrom(num)); */

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/* double Length3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
	return Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));
}

Console.Write("Введите 1-ю координату точки А:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2-ю координату точки А:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 3-ю координату точки А:");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 1-ю координату точки В:");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 1-ю координату точки В:");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 1-ю координату точки В:");
double zB = Convert.ToDouble(Console.ReadLine());

double length3D = Length3D(xA, yA, zA, xB, yB, zB);
Console.WriteLine(length3D); */

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/* int[] CubeList(int num)
{
	int current = 1;
	int i = 0;
	int[] arr = new int[num];
	while (current <= num)
	{
		arr[i] = Convert.ToInt32((Math.Pow(current, 3)));
		i++;
		current++;
	}
	return arr;
}

Console.Write("Введите число, таблицу кубов которого хотите получить: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] cubeList = CubeList(num);
Console.Write(string.Join(", ", cubeList)); */