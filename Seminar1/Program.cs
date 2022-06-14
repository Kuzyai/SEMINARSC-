int num, result;

Console.Write("Введите натуральное число, квадрат которого хотите получить: ");
num = Convert.ToInt32(Console.ReadLine());

result = num * num;

Console.WriteLine("Квадрат числа " + num + " равен: " + result);