/* string[] Words(int size)
{
	string[] words = new string[size];
	for (int i = 0; i < size; i++)
	{
		Console.Write($"Введите {i + 1} слово: ");
		words[i] = Console.ReadLine();
	}
	return words;
}
string[] DoubleWords(string[] words1, string[] words2)
{
	int maxLength = 0;
	if (words1.Length > words2.Length) maxLength = words1.Length;
	else maxLength = words2.Length;
	string[] doubleWorlds = new string[maxLength];
	for (int i = 0; i < maxLength; i++)
	{
		if (i >= words2.Length) doubleWorlds[i] = $"{words1[i]}";
		else if ((i >= words1.Length)) doubleWorlds[i] = $"{words2[i]}";
		else doubleWorlds[i] = $"{words1[i]} {words2[i]}";
	}
	return doubleWorlds;
}
Console.Write("Введите количество слов в массиве 1: ");
int size1 = Convert.ToInt32(Console.ReadLine());
string[] words1 = Words(size1);
Console.Write("Введите количество слов в массиве 2: ");
int size2 = Convert.ToInt32(Console.ReadLine());
string[] words2 = Words(size2);
string[] doubleWords = DoubleWords(words1, words2);
Console.WriteLine(string.Join(", ", doubleWords)); */

/* int CountWords(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
		if (array[i][0].ToString().ToUpper() == "Y" || array[i][0].ToString().ToUpper() == "W") count++;
	return count;
}
string[] Words(int size)
{
	string[] words = new string[size];
	for (int i = 0; i < size; i++)
	{
		Console.Write($"Введите {i + 1} слово: ");
		words[i] = Console.ReadLine();
	}
	return words;
}
Console.Write("Введите количество слов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] words = Words(size);
int count = CountWords(words);
Console.WriteLine($"Количество слов начинающихся на букву Y или W составляет {count}"); */