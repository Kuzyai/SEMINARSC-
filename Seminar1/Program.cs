// int num, result;

// Console.Write("Введите натуральное число, квадрат которого хотите получить: ");
// num = Convert.ToInt32(Console.ReadLine());

// result = num * num;

// Console.WriteLine("Квадрат числа " + num + " равен: " + result);

int num1, num2;

Console.Write("Введите первое натуральное число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
	Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
}
else
{
	Console.WriteLine("Число " + num1 + " не является квадратом числа " + num2);
}