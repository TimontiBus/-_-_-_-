// При вводе слова с цифрами, код выводит только буквы.


// string GetLettersFromString(string s)
// {
// 	string letters = "";
// 	foreach (char e in s)
// 	{
// 		if (char.IsAsciiLetter(e) == true)
// 		{
// 			letters = letters + e;
// 		}
// 	}
// 	return letters;
// }

// string str = Console.ReadLine();
// string resull = GetLettersFromString(str);
// Console.WriteLine(resull);

int Fact(int n)
{
	if (n == 1 || n == 0)
	{
		Console.WriteLine($"Stop: {n}");
		return 1;
	}
	Console.WriteLine(n);
	return n * Fact(n - 1);
}

Console.Write(Fact(5));

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (до следующей точки)