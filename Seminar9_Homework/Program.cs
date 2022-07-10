// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/* int SumElementDiapazon(int m, int n)
{
	if (m == n) return m;
	return m + SumElementDiapazon(m + 1, n);
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = SumElementDiapazon(num1, num2);
Console.WriteLine(sum); */

// Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
/* int QuantDigits(int num)
{
	if (num / 10 == 0) return 1;
	return 1 + QuantDigits(num / 10);
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = QuantDigits(num);
Console.WriteLine(result); */