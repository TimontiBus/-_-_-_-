﻿
int[] array = { 2, 5, 4, 7, 8, 50, 1, 3, 8, 5 };
int i = 0;

while (i < array.Length)
{
	if (array[i] % 2 == 0)
	{
		Console.Write($"{array[i]} ");
	}
	i = i + 1;
}