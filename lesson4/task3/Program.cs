﻿// При вводе слова с цифрами, код выводит только буквы.


string GetLettersFromString(string s)
{
	string letters = "";
	foreach (char e in s)
	{
		if (char.IsAsciiLetter(e) == true)
		{
			letters = letters + e;
		}
	}
	return letters;
}

string str = Console.ReadLine();
string resull = GetLettersFromString(str);
Console.WriteLine(resull);
