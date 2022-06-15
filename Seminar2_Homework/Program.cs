// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/* int ThreeDigitNumber(int num)
{
	num %= 100;
	num /= 10;
	return num;
}

int result;
Console.Write("Введите 3-х значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (true)
{
	if (num > 99 && num < 1000)
	{
		result = ThreeDigitNumber(num);
		break;
	}
	else
	{
		Console.Write("Введите 3-х значное число: ");
		num = Convert.ToInt32(Console.ReadLine());
	}
}

Console.WriteLine($"Второй разряд числа {num} равен {result}"); */

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* void InformThreeDigitNumber(int num)
{
	int result;
	if (num > 99)
	{
		int length = Convert.ToInt32(Convert.ToString(num).Length) - 3;
		result = (num / Convert.ToInt32(Math.Pow(10, length))) % 10;
		Console.WriteLine($"Третья цифра числа {num} равна {result}");
	}
	else Console.WriteLine($"Третьей цифры числа {num} нет.");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
InformThreeDigitNumber(num); */

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/* string WeekNumber(int day)
{
	if (day == 6 || day == 7) return $"День под номером {day} является выходным.";
	else return $"День под номером {day} не является выходным";
}

Console.Write("Введите номер для недели: ");
int day = Convert.ToInt32(Console.ReadLine());
string fraze;

while (true)
{
	if (day >= 1 && day <= 7)
	{
		fraze = WeekNumber(day);
		break;
	}
	else
	{
		Console.Write("Введите номер для недели: ");
		day = Convert.ToInt32(Console.ReadLine());
	}
}

Console.Write(fraze); */