/* string Range(int num)
{
	if (num == 1) return "Диапазон координат в этой четверти от x > 0 и y > 0.";
	if (num == 2) return "Диапазон координат в этой четверти от x < 0 и y > 0.";
	if (num == 3) return "Диапазон координат в этой четверти от x < 0 и y < 0.";
	if (num == 4) return "Диапазон координат в этой четверти от x > 0 и y < 0.";
	return "Вы не правильно ввели номер четверти.";
}

Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
string range = Range(num);
Console.WriteLine(range); */

void SquaresList(int num)
{
	num = Math.Abs(num);
	int count = 1;
	int result;
	while (count <= num)
	{
		result = count * count;
		Console.Write($"{result} ");
		count++;
	}
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
SquaresList(num);