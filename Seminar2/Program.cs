/* void RandomNumber()
{
	int num = new Random().Next(100, 1000);
	string result = Convert.ToString(num / 100);
	result += num % 10;
	Console.WriteLine($"Результат обработки числа {num} равен {result}");
}
RandomNumber(); */

/* string DoubleNumber(int num1, int num2)
{
	string result;
	if (num2 % num1 == 0) return result = "Второе число кратно первому";
	else return result = Convert.ToString(num2 % num1);
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(DoubleNumber(num1, num2)); */

/* void CheckNumber(int num)
{
	if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"Число {num} кратно одновременно 7 и 23");
	else Console.WriteLine($"Число {num} не кратно одновременно 7 и 23");
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
CheckNumber(a); */