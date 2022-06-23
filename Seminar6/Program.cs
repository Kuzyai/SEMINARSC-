/* bool ExistenceDelta(int num1, int num2, int num3)
{
	if (num1 + num2 > num3 && num2 + num3 > num1 && num3 + num1 > num2) return true;
	return false;
}
Console.Write("Введите длину первой стороны: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третей стороны: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ExistenceDelta(num1, num2, num3)); */

/* int[] Fibonacci(int n)
{
	int[] arr = new int[n];
	arr[0] = 0;
	arr[1] = 1;
	for (int i = 2; i < n; i++)
	{
		arr[i] = arr[i - 1] + arr[i - 2];
	}
	return arr;
}
void ConclusionArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}
}
Console.Write("Введите порядковый номер числа Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonacci(n);
ConclusionArray(array); */

using System.Text;
string BinaryDigit(int n)
{
	string result = "";
	char temp;
	while (n > 0)
	{
		result += Convert.ToString(n % 2);
		n /= 2;
	}
	StringBuilder str = new StringBuilder(result);
	for (int i = 0; i < str.Length - i - 1; i++)
	{
		temp = str[i];
		str[i] = str[str.Length - i - 1];
		str[str.Length - i - 1] = temp;
	}
	return result = str.ToString();
}
Console.Write("Введите число которое хотите преобразовать: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(BinaryDigit(n));