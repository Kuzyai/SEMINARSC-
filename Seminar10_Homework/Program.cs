// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
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
int CountWords(string[] words, string[] vowels)
{
	int count = 0;
	for (int i = 0; i < words.Length; i++)
		for (int j = 0; j < vowels.Length; j++)
			if (words[i][0].ToString().ToLower() == vowels[j].ToString()) count++;
	return count;
}
Console.Write("Введите количество слов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] words = Words(size);
string[] vowels = { "a", "e", "i", "o", "u", "y" };
int count = CountWords(words, vowels);
Console.WriteLine($"Количество слов начинающихся на гласную букву составляет - {count}."); */

// Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
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
string[] DoubleWords(string[] words)
{
	int size = 0;
	if (words.Length % 2 == 0) size = words.Length / 2;
	else size = words.Length / 2 + 1;
	string[] newWords = new string[size];
	for (int i = 0; i < words.Length; i += 2)
	{
		if (words.Length % 2 != 0)
			if (i == words.Length - 1) newWords[i / 2] = $"{words[i]}";
			else newWords[i / 2] = $"{words[i]} {words[i + 1]}";
		else newWords[i / 2] = $"{words[i]} {words[i + 1]}";
	}
	return newWords;
}
Console.Write("Введите количество слов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] words = Words(size);
string[] newWords = DoubleWords(words);
Console.WriteLine(string.Join(", ", newWords)); */