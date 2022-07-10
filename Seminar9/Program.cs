/* void ShowNums(int m, int n)
{
	if (n != m) ShowNums(m, n - 1);
	Console.Write($"{n} ");
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) ShowNums(num2, num1);
else ShowNums(num1, num2); */

/* int SumNumbers(int num)
{
	if (num == 0) return 0;
	return num % 10 + SumNumbers(num / 10);
}
Console.Write("Введите число сумму цифр которого Вы хотите получить: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(num);
Console.WriteLine(result); */

/* int DegreeNumber(int a, int b)
{
	if (b == 1) return a;
	return DegreeNumber(a, b - 1) * a;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числa: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = DegreeNumber(a, b);
Console.WriteLine(result); */